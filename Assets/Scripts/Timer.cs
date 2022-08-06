using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool stopwatchActive = true;
    public Text timer;
    float currentTime;

    public Text scoreText;
    public float multiplier = 5;

    void Start()
    {
        currentTime =  0;
    }

    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        Scoring.totalScore = Mathf.RoundToInt(currentTime * multiplier);
        scoreText.text = Scoring.totalScore.ToString();
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timer.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopWatchStop()
    {
      stopwatchActive = false;
    }
}
