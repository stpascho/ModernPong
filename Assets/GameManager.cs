using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int computerScore = 0; 
    public static int playerScore = 0;

    //public GUISkin skin;

    public static void Score(string wallName)
    {  //the "public tag" is important, otherwise you cant acces it form "SideWalls.cs"
        if (wallName == "RightWall")
        {
            playerScore += 1;
        }

        else
        {
            computerScore += 1;
            
        }
        Debug.Log("Player Score 01 is" + computerScore);
        Debug.Log("Player Score 02 is" + playerScore);
    }


    void OnGUI()
    {

        GUI.Label(new Rect((Screen.width / 2) - 150, 25, 100, 100), "" + playerScore);
        GUI.Label(new Rect(Screen.width / 2 + 150, 25, 100, 100), "" + computerScore);


    }
}
