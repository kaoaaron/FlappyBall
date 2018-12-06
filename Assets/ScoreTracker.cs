using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{

    public Text score;
    private int scoreTracker = 0;
    private float timer;
    public int scores;
    // Use this for initialization
    void Start()
    {
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            scoreTracker += 1;

            //We only need to update the text if the score changed.
            score.text = scoreTracker.ToString();

            //Reset the timer to 0.
            timer = 0;
        }
    }
}
