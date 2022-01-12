using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;

    int score = 0;

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
        //score = score + 1;
        score++;
        print(score);
    }



}

