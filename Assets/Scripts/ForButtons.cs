using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForButtons : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void highScores()
    {
        SceneManager.LoadScene("ScoreBoard");
    }

    public void exit()
    {
        Application.Quit();
    }
}
