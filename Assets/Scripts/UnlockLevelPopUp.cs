using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevelPopUp : MonoBehaviour
{
    [System.Serializable]
    public struct CategoryName
    {
        public string name;
        public Sprite sprite;
    };

    public GameData currentGameData;
    public List<CategoryName> categorieNames;
    public GameObject winPopup;
    public Image categoryNameImage;

    void Start()
    {
        winPopup.SetActive(false);

    }
    private void OnDisable()
    {

    }

    private void OnUnlockNextCategory() 
    {
        bool captureNext = false;

        foreach (var writing in categorieNames)
        {
            if (captureNext)
            {

                categoryNameImage.sprite = writing.sprite;
                captureNext = false;
                break;
            }
            if (writing.name == currentGameData.selectedCategoryName)
            {
                captureNext = true;
            }
        }
        winPopup.SetActive(true);
    }

}
