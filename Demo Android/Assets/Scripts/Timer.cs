using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 30;
    public bool runTimer;
    public Text timeText;
    public GameObject textObj;
    void Start()
    {
        runTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (runTimer)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTimer(timeRemaining);
                if(timeRemaining <= 10)
                {
                    blinkRed();
                }
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().lose();
                timeRemaining = 0;
                
                runTimer = false;
                gameObject.SetActive(false);
            }
        }
    }
    public void stop()
    {
        runTimer = false;
        textObj.SetActive(false);
        gameObject.SetActive(false); //need to change for text obj as well
       
    }

    public bool isTimerRunning()
    {
        return runTimer;
    }

    void DisplayTimer(float toDisplay)
    {
        toDisplay += 1;
        float minutes = Mathf.FloorToInt(toDisplay/ 60);
        float seconds = Mathf.FloorToInt(toDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void blinkRed()
    {
        if((int)timeRemaining % 2 == 0)
        {
            timeText.color = Color.red;
        }
        else
        {
            timeText.color = Color.white;
        }
    }
}

