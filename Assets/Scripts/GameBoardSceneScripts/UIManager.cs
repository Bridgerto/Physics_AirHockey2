using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header ("Canvas")]
    public GameObject CanvasGame;
    public GameObject CanvasRestart;

    [Header("CanvasRestart")]
    public GameObject WinTxt;
    public GameObject LoseTxt;

    [Header("Other")]
    public ScoreTracker scoreTracker;
   
    public PuckScript pScript;
    public Humanplayer hpScript;
    public AIplayer aiScript;


    public void ShowRestartCanvas(bool didAIWin)
    {
        Time.timeScale = 0;
        CanvasGame.SetActive(false);
        CanvasRestart.SetActive(true);

        if (didAIWin)
        {
            WinTxt.SetActive(false);
            LoseTxt.SetActive(true);
        }
        else
            WinTxt.SetActive(true);
            LoseTxt.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        CanvasGame.SetActive(true);
        CanvasRestart.SetActive(false);

        scoreTracker.ResetScore();
        pScript.CenterPuck();
        hpScript.ResetPosition();
        aiScript.ResetPosition();
    }

}
