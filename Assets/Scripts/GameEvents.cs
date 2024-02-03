using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    public delegate void EnablesquareSelection();
    public static event EnablesquareSelection OnEnableSquareSelection;

    public static void EnableSquareSelectionMethod()
    {
        if (OnEnableSquareSelection != null)
        {
            OnEnableSquareSelection();
        }
    }

    //***********************************************************************

    public delegate void DisablesquareSelection();
    public static event DisablesquareSelection OnDisableSquareSelection;

    public static void DisableSquareSelectionMethod()
    {
        if (OnDisableSquareSelection != null)
        {
            OnDisableSquareSelection();
        }
    }

    //***********************************************************************

    public delegate void SelectSquare(Vector3 position);
    public static event SelectSquare OnSelectSquare;

    public static void SelectSquareMethod(Vector3 position)
    {
        if (OnSelectSquare != null)
        {
            OnSelectSquare(position);
        }
    }

    //***********************************************************************

    public delegate void CheckSquare(string letter ,Vector3 squarePosition,int squareIndex);
    public static event CheckSquare OnCheckSquare;

    public static void CheckSquareMethod(string letter, Vector3 squarePosition, int squareIndex)
    {
        if (OnCheckSquare != null)
        {
            OnCheckSquare(letter, squarePosition, squareIndex);
        }
    }

    //***********************************************************************

    public delegate void ClearSelction();
    public static event ClearSelction OnClearSelction;

    public static void ClearSelctionMethod()
    {
        if (OnClearSelction != null)
        {
            OnClearSelction();
        }
    }

    //***********************************************************************

    public delegate void CorrectWord(string word,List<int> squareIndexes);
    public static event CorrectWord OnCorrectWord;

    public static void CorrectWordMethod(string word, List<int> squareIndexes)
    {
        if (OnCorrectWord != null)
        {
            OnCorrectWord(word,squareIndexes);
        }
    }


   

    //***********************************************************************

    public delegate void LoadNextLevel();
    public static event LoadNextLevel OnLoadNextLevel;

    public static void LoadNextLevelMethod()
    {
        if (OnLoadNextLevel != null)
        {
            OnLoadNextLevel();
        }
    }


    //***********************************************************************

    public delegate void ToggleSoundFx();
    public static event ToggleSoundFx OnToggleSoundFx;

    public static void ToggleSoundFxMethod()
    {
        if (OnToggleSoundFx != null)
        {
            OnToggleSoundFx();
        }
    }
}
