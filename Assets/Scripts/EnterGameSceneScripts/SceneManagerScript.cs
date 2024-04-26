
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class SceneManagerScript : MonoBehaviour
{
    
    private float timer = 5f;
    private TextMeshProUGUI timerSeconds;


    private void Start()
    {
      
        timerSeconds = GetComponent<TextMeshProUGUI>();
        
    }

    private void Update()
    {
       timer -= Time.deltaTime;
       timerSeconds.text = timer.ToString("0");
        if (timer <= 0)
        {
            SceneManager.LoadScene("GameBoardScene");
        }
    }



}
