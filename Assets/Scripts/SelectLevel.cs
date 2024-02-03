using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public static SelectLevel Instance;
    public GameLevelData Data;
    public int Number
    {
        get
        {
            return PlayerPrefs.GetInt("Level", 0);
        }
        set
        {
            PlayerPrefs.SetInt("Level", value);
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void SelectLevelBtn( )
    {
    }

    public void LevelSelectBtn(int Numbers)
    {
        Number = Numbers;
        SceneManager.LoadScene("GameScene");
    }
}
