using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu]
public class AlphabetsData : ScriptableObject
{
    [System.Serializable]
    public class letterData
    {
        public string letter;
        public Sprite image;
    }

    public List<letterData> AlphabetsPlain = new List<letterData>();
    public List<letterData> AlphabetsNormal = new List<letterData>();
    public List<letterData> AlphabetsHighlighted = new List<letterData>();
    public List<letterData> AlphabetsWrong = new List<letterData>();
}
