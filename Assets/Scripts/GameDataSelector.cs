using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataSelector : MonoBehaviour
{
    public GameData currentGameData;
    public GameLevelData levelData;

    private void Awake()
    {
        SelectSequantalBoardData();
    }

    private void Start()
    {

    }
    private void SelectSequantalBoardData()
    {
        //foreach (var data in levelData.data)
        //{
        //    if (data.categoryName == currentGameData.selectedCategoryName)
        //    {
        //        //var boardIndex = DataSever.ReadCategoryCurrentIndexValue(currentGameData.selectedCategoryName);

        //        //if (boardIndex < data.boardData.Count)
        //        //{
        //        //    currentGameData.selectedBoardData = data.boardData[boardIndex];
        //        //}
        //        //else
        //        //{
        //        //    var randomIndex = Random.Range(0, data.boardData.Count);
        //        //    currentGameData.selectedBoardData = data.boardData[randomIndex];
        //        //}

        //    }
        //}
        Debug.Log(SelectLevel.Instance.Number);
        currentGameData.selectedBoardData = levelData.data[SelectPuzzleButton.instance.CategoryNumber].boardData[SelectLevel.Instance.Number];

    }

   
}
 