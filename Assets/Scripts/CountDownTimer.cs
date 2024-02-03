using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    public GameObject GameOverPopup;
    public GameData currentGameData;
    public TextMeshProUGUI timerTxt;

    private float _timeLeft;
    private float _minutes;
    private float _seconds;
    private float _oneSecondDown;
    public bool _timeOut;
    public bool _stopTimer;

    public static CountDownTimer instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        _stopTimer = false;
        _timeOut = false;
        _timeLeft = currentGameData.selectedBoardData.timeInSecond;
        _oneSecondDown = _timeLeft - 1f;

    }

   
    private void Update()
    {
        if (_stopTimer == false)
        {
           _timeLeft-= Time.deltaTime;
        }
        if (_timeLeft <= _oneSecondDown)
        {
            _oneSecondDown = _timeLeft - 1f;
        }
    }
    private void OnGUI()
    {
        if (_timeOut == false)
        {
            if (_timeLeft > 0)
            {
                _minutes = Mathf.Floor(_timeLeft / 60);
                _seconds=Mathf.RoundToInt(_timeLeft%60);

                timerTxt.text = _minutes.ToString("00") + ":" + _seconds.ToString("00");
            }
            else
            {
                _stopTimer = true;
                ActivateGameOverGui();
            }
        }
    }

    private void ActivateGameOverGui()
    {
        GameOverPopup.SetActive(true);
        _timeOut = true;
    }

}
