using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public float speed = 500f;
    public int state = 0;
    public GameObject score;

    public void ButtonPressed()
    {
        state = 1;
        GameObject spawnObs = GameObject.Find("GameManager");
        spawnObs.GetComponent<ObstacleSpawn>().enabled = true;

        GameObject player = GameObject.Find("Player");
        player.GetComponent<Movement>().enabled = true;

        score.SetActive(true);

        Debug.Log("Pressed");
        gameObject.transform.GetChild(0).GetComponent<Animator>().enabled = true;
    }
}
