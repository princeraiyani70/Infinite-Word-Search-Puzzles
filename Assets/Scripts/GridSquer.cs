using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents;

public class GridSquer : MonoBehaviour
{
    public int SquareIndex { get; set; }

    private AlphabetsData.letterData _normalLetterData;
    private AlphabetsData.letterData _selectedLetterData;
    private AlphabetsData.letterData _correctLetterData;

    private SpriteRenderer _displayedImage;

    private bool _selecterd;
    private bool _clicked;
    private int _index = -1;
    private bool _correct;

    private AudioSource _source;

    public void SetIndex(int index)
    {
        _index = index;
    }

    public int GetIndex()
    {
        return _index;
    }


    private void Start()
    {
        _selecterd = false;
        _clicked = false;
        _correct = false;
        _displayedImage = GetComponent<SpriteRenderer>();
        _source= GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        GameEvents.OnEnableSquareSelection += OnEnableSquareSelection;
        GameEvents.OnDisableSquareSelection += OnDisableSquareSelection;
        GameEvents.OnSelectSquare += SelectSquare;
        GameEvents.OnCorrectWord += CorrectWord;
    }

    private void OnDisable()
    {
        GameEvents.OnEnableSquareSelection -= OnEnableSquareSelection;
        GameEvents.OnDisableSquareSelection -= OnDisableSquareSelection;
        GameEvents.OnSelectSquare -= SelectSquare;
        GameEvents.OnCorrectWord -= CorrectWord;
    }

    private void CorrectWord(string word,List<int> squaresIndex)
    {
        if (_selecterd && squaresIndex.Contains(_index))
        {
            _correct = true;
            _displayedImage.sprite = _correctLetterData.image;
        }
        _selecterd= false;
        _clicked= false;
    }

    public void OnEnableSquareSelection()
    {
        _clicked = true;
        _selecterd = false;
    }
    public void OnDisableSquareSelection()
    {
        _selecterd = false;
        _clicked = false;

        if (_correct == true)
        {
            _displayedImage.sprite = _correctLetterData.image;
        }
        else
        {
            _displayedImage.sprite=_normalLetterData.image;
        }
    }

    private void SelectSquare(Vector3 Position)
    {
        if (this.gameObject.transform.position == Position)
        {
            _displayedImage.sprite = _selectedLetterData.image;
        }

    }

    public void SetSprite(AlphabetsData.letterData normalLetterData, AlphabetsData.letterData selectedLetterData,
        AlphabetsData.letterData correctLetterData)
    {
        _normalLetterData = normalLetterData;
        _selectedLetterData = selectedLetterData;
        _correctLetterData = correctLetterData;

        GetComponent<SpriteRenderer>().sprite = _normalLetterData.image;
    }

    private void OnMouseDown()
    {
        OnEnableSquareSelection();
        GameEvents.EnableSquareSelectionMethod();
        CheckSquare();
        _displayedImage.sprite = _selectedLetterData.image;
    }

    private void OnMouseEnter()
    {
        CheckSquare();
    }

    private void OnMouseUp()
    {
        GameEvents.ClearSelctionMethod();
        GameEvents.DisableSquareSelectionMethod();
    }

    public void CheckSquare()
    {
        if (_selecterd == false && _clicked == true)
        {
            if (SoundManager.instance.IsSoundFxMuted() == false)
            {
                _source.Play();
            }
            _selecterd = true;
            GameEvents.CheckSquareMethod(_normalLetterData.letter, gameObject.transform.position, _index);
        }
    }

}
