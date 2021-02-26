using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completedLevelUI;

    public void completeLevel()
    {
        if (ScoreScript.scoreValue == 1){
        completedLevelUI.SetActive(true);
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false){
            {
                gameHasEnded=true;
                Debug.Log("game won");
            }
        }
    }

}
