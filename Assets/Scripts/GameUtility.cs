using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUtility : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MuteToggleBgMusic()
    {
        SoundManager.instance.ToggleBgMusic();
    }

    public void MuteSoundMusic()
    {
        SoundManager.instance.ToggleSoundFx();
    }
}
