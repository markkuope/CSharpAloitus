using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;

    int score = 0;

    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString(); // muutetaan samalla score int -arvosta string -arvoksi
        //print(score);
    }
}

