using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private bool _muteBgMusic = false;
    private bool _muteSoundFx = false;
    public static SoundManager instance;

    private AudioSource _audioSource;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
       _audioSource=GetComponent<AudioSource>();
        _audioSource.Play();
    }

    public void ToggleBgMusic()
    {
        _muteBgMusic= !_muteBgMusic;
        if (_muteBgMusic)
        {
            _audioSource.Stop();
        }
        else
        {
            _audioSource.Play();
        }
    }

    public void ToggleSoundFx()
    {
        _muteSoundFx= !_muteSoundFx;
        GameEvents.ToggleSoundFxMethod();
    }

    public bool IsBgMusicMuted()
    {
        return _muteBgMusic; ;
    }
    public bool IsSoundFxMuted()
    {
        return _muteSoundFx;
    }

    public void SilienceBgMusic(bool silence)
    {
        if (_muteBgMusic == false)
        {
            if (silence)
            {
                _audioSource.volume = 0;
            }
            else
            {
                _audioSource.volume = 1f;   
            }
        }
    }
}
