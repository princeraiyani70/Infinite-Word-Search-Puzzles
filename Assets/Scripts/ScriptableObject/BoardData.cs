using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
[CreateAssetMenu]
public class BoardData : ScriptableObject
{
    [System.Serializable]
    public class searchingWord
    {
        [HideInInspector]
        public bool Found = false;
        public string word;
    }

    [System.Serializable]
    public class BoardRow
    {
        public int Size;
        public string[] Row;

        public BoardRow() { }

        public BoardRow(int size)
        {
            CreateRow(size);
        }

        public void CreateRow(int size)
        {
            Size = size;
            Row = new string[Size]; 
            ClearRow();
        }

        public void ClearRow()
        {
            for (int i = 0; i < Size; i++)
            {
                Row[i] = " ";
            }
        }
    }

    public int PlusPursentege;
    public float timeInSecond;
    public int Colums = 0;
    public int Rows = 0;

    public BoardRow[] Board;
    public List<searchingWord> searchWords=new List<searchingWord>();

    public void ClerData()
    {
        foreach (var word in searchWords)
        {
            word.Found = false;
        }
    }

    public void ClearWithEmptyString()
    {
        for (int i = 0; i < Colums; i++)
        {
            Board[i].ClearRow();
        }
    }

    public void  CreateNewBoard()
    {
        Board = new BoardRow[Colums];
        for(int i = 0;i < Colums; i++)
        {
            Board[i] = new BoardRow(Rows);
        }
    }
}
