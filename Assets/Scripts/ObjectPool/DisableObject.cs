using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    [SerializeField] private float lowerLimit;

    private void Update()
    {
        DisableObj();
    }

    private void DisableObj()
    {
        if (transform.position.x < lowerLimit || GameController.isGameOver)
        {
            gameObject.SetActive(false);
        }
    }

    
}
