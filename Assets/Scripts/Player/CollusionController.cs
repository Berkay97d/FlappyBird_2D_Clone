using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollusionController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Obstacle"))
        {
            Debug.Log("OBS");
            GameController.isGameOver = true;
        }
        else if (col.CompareTag("Point"))
        {
            Debug.Log("Point");
            UIController.WinScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameController.isGameOver = true;
    }
}
