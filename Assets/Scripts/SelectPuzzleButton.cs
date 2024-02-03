using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectPuzzleButton : MonoBehaviour
{
    public GameData gameData;
    public GameLevelData levelData;
    public TextMeshProUGUI categoryTxt;
    //private bool levelLocked;

    public int LevelPurs = 0;

    private string gameSceneName = "SelectCategoryLevels";

    public static SelectPuzzleButton instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {

        //levelLocked = false;
        var button = GetComponent<Button>();
        //GetComponent<Button>().onClick.AddListener(OnButtonClick);
        //UpdateButtonInformation();
        //if (levelLocked)
        //{
        //    button.interactable = false;
        //}
        //else
        //{
        //    button.interactable = true;
        //}

    }

    void Update()
    {

    }
    //private void UpdateButtonInformation()
    //{
    //    var currentIndex = -1;
    //    var totalBoards = 0;

    //    foreach (var data in levelData.data)
    //    {
    //        if (data.categoryName == gameObject.name)
    //        {
    //            currentIndex = DataSever.ReadCategoryCurrentIndexValue(gameObject.name);
    //            totalBoards = data.boardData.Count;

    //            if (levelData.data[0].categoryName == gameObject.name && currentIndex < 0)
    //            {
    //                DataSever.SaveCategoryData(levelData.data[0].categoryName, 0);
    //                currentIndex = DataSever.ReadCategoryCurrentIndexValue(gameObject.name);
    //                totalBoards = data.boardData.Count;
    //            }
    //        }
    //    }

    //    if (currentIndex == -1)
    //    {
    //        levelLocked = true;
    //    }
    //    categoryTxt.text = levelLocked ? string.Empty : (currentIndex.ToString() + "%");

    //}

    public int CategoryNumber
    {
        get
        {
            return PlayerPrefs.GetInt("Category", 0);
        }
        set
        {
            PlayerPrefs.SetInt("Category", value);
        }
    }
    public void OnButtonClick(int selectCategory)
    {
        CategoryNumber = selectCategory;
        gameData.selectedCategoryName = gameObject.name;
        SceneManager.LoadScene(gameSceneName);
    }
}
