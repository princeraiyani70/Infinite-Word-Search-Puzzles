using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    private string gameSceneName = "GameScene";
 
    public void LevelClick(int n)
    {
        PlayerPrefs.SetInt("SelectedLevel", n);
        SceneManager.LoadScene(gameSceneName);
    }
   

}
