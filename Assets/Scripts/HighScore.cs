using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HighScore : MonoBehaviour
{
    public Text Time;

    private void Awake()
    {
        Time.text = Scoring.totalScore.ToString();
    }
}
