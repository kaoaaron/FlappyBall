using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTowards : MonoBehaviour {

    // Speed in units per sec.
    public float speed = 500f;
    private int state = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);

        if(gameObject.transform.position.x > 50 && state == 0)
        {
            state = 1;
            GameObject canvasObject = GameObject.Find("Canvas");
            Transform textTr = canvasObject.transform.Find("Score");
            Text text = textTr.GetComponent<Text>();

            int score = Convert.ToInt32(text.GetComponent<Text>().text)+1;

            text.GetComponent<Text>().text = score.ToString();
        }
    }
}
