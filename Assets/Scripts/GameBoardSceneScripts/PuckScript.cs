using System.Collections;
using UnityEngine;

public class PuckScript : MonoBehaviour
{
    public ScoreTracker ScoreTrackerInstance;
    public static bool WasGoal{get; private set; }
    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        WasGoal = false;  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (!WasGoal)
       {
           if (other.tag == "AIGoal")
           {
                ScoreTrackerInstance.Increment(ScoreTracker.Score.PlayerScore);
                WasGoal = true;
                StartCoroutine(ResetPuck());
           }
           else if (other.tag == "HumanPlayerGoal")
           {
                ScoreTrackerInstance.Increment(ScoreTracker.Score.AiScore);
                WasGoal = true;
                StartCoroutine(ResetPuck());

            }

        }
    }

    public void CenterPuck()
    {
        rb.position = new Vector3(0, 0);
    }

    private IEnumerator ResetPuck()
    {
        yield return new WaitForSecondsRealtime(1);
        WasGoal = false;
        rb.velocity = rb.position = new Vector2(0, 0);
    }
}
