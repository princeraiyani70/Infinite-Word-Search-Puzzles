using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggleButton : MonoBehaviour
{
    public enum ButtonType
    {
        BgMusic,
        SoundFx
    };

    public ButtonType type;

    public Sprite onSprite;
    public Sprite offSprite;

    public GameObject button;
    public Vector3 _offButtonPosition;

    private Vector3 _onButtonPosition;
    private Image _image;

    void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = onSprite;
        _onButtonPosition = button.GetComponent<RectTransform>().anchoredPosition;
        ToggleButton();
    }

    public void ToggleButton()
    {
        var muted = false;

        if(type == ButtonType.BgMusic)
        {
            muted = SoundManager.instance.IsBgMusicMuted();
        }
        else
        {
            muted=SoundManager.instance.IsSoundFxMuted();
        }

        if (muted)
        {
            _image.sprite = offSprite;
            button.GetComponent<RectTransform>().anchoredPosition = _offButtonPosition;
        }
        else
        {
            _image.sprite = onSprite;
            button.GetComponent<RectTransform>().anchoredPosition = _onButtonPosition;
        }
    }
}
