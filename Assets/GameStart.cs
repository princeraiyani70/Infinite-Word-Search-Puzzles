using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameLevelData levelData;
    public GameData gameData;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (SelectLevel.Instance.Number == i)
            {

            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
