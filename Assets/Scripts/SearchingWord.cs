using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SearchingWord : MonoBehaviour
{
    public TextMeshProUGUI displayedTxt;
    public Image crossLine;

    private string _word;
    void Start()
    {

    }
    private void OnEnable()
    {
        GameEvents.OnCorrectWord += CorrectWord;
    }
    private void OnDisable()
    {
        GameEvents.OnCorrectWord -= CorrectWord;
    }

    public void SetWord(string word)
    {
        _word = word;
        displayedTxt.text = word;
    }
    private void CorrectWord(string word, List<int> squareIndexs)
    {
        if (word == _word)
        {
            crossLine.gameObject.SetActive(true);
        }
    }
}
