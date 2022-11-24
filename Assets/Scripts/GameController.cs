using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static bool isGameOver;
    
    private void Update()
    {
        if (isGameOver)
        {
            Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        isGameOver = false;
        Time.timeScale = 1;
        UIController.score = 0;
        SceneManager.LoadScene(0);
    }
}
