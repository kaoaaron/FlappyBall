using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class EndGame : MonoBehaviour {

    public GameObject panel;
    bool gameEnded = false;
   // float delay = 1f;
    private TextMeshProUGUI text;
    public TextMeshProUGUI highscore;
    public Text text2;


    void Start()
    {
        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
        }
    }

    public void GameOver()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
        }

        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obj in taggedObjects)
        {
            obj.GetComponent<MoveTowards>().enabled = false;
        }

        GameObject player = GameObject.Find("Player");
        player.GetComponent<Movement>().enabled = false;

        GameObject spawnObs = GameObject.Find("GameManager");
        spawnObs.GetComponent<ObstacleSpawn>().CancelInvoke();

        panel.SetActive(true);

        Transform textTr = panel.transform.Find("EndText");
        text = textTr.GetComponent<TextMeshProUGUI>();

        GameObject canvasObject = GameObject.Find("Canvas");
        Transform textTra = canvasObject.transform.Find("Score");
        Text scoretext = textTra.GetComponent<Text>();

        text.text = "Score: " + scoretext.GetComponent<Text>().text;

        Debug.Log(Convert.ToInt32(scoretext.GetComponent<Text>().text));

        if(Convert.ToInt32(scoretext.GetComponent<Text>().text) > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", Convert.ToInt32(scoretext.GetComponent<Text>().text));
        }

        highscore.text = "High Score: " + PlayerPrefs.GetInt("Highscore").ToString();

        // text.text = "red";
        //Invoke("Restart", delay);
    }

    public void Restart()
    {
        
        SceneManager.LoadScene("Game");
    }
}
