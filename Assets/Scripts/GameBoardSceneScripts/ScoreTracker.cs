using UnityEngine;
using TMPro;


public class ScoreTracker : MonoBehaviour
{
    public enum Score
    {
        AiScore, PlayerScore
    }

    public TextMeshProUGUI AiScoreTxt, PlayerScoreTxt;

    public UIManager uiManager;

    public int MaxScore;

    #region Scores
    private int aiScore, playerScore;

    private int AiScore
    {
        get { return aiScore; }
        set
        {
            aiScore = value;
            if (value == MaxScore)
               uiManager.ShowRestartCanvas(true);       
        }
    }

    private int PlayerScore
    {
        get { return playerScore; }
        set
        {
            playerScore = value;
            if (value == MaxScore)
                uiManager.ShowRestartCanvas(false);
        }
    }
    #endregion


    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoreTxt.text = (++AiScore).ToString();
        else
            PlayerScoreTxt.text = (++PlayerScore).ToString();
    }

    public void ResetScore()
    {
        PlayerScore = 0;
        AiScore = 0;
        PlayerScoreTxt.text = "0";
        AiScoreTxt.text = "0";

    }
}
