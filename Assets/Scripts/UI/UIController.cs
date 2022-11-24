using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
   [SerializeField] private Canvas inGameCanvas;
   [SerializeField] private Canvas endGameCanvas;
   [SerializeField] private TMP_Text scoreText;
   [SerializeField] private TMP_Text endGameScoreText;
   [SerializeField] private TMP_Text bestScoreText;
   
   public static int score;
   
   private void Update()
   {
      ControlUI();
   }

   private void ControlUI()
   {
      if (PlayerPrefs.GetInt("HighScore") < score)
      {
         PlayerPrefs.SetInt("HighScore", score);
      }
      
      scoreText.text = score.ToString();
      endGameScoreText.text = "Score: " + score; 
      bestScoreText.text = "Best Score: " + PlayerPrefs.GetInt("HighScore");
      
      if (GameController.isGameOver)
      {
         inGameCanvas.gameObject.SetActive(false); 
         endGameCanvas.gameObject.SetActive(true);
      }

   }
   public static void WinScore()
   {
      score++;
   }

   
   
   
   
   
   
}
