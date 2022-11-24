using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private BoxCollider2D collider2D;
    private float groundWidth;

    private void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        groundWidth = collider2D.size.x;
    }

    private void Update()
    {
        if (transform.position.x <= -groundWidth * 0.25f)
        {
            transform.position = new Vector2(transform.position.x + 2f * groundWidth * 0.25f, transform.position.y);
        }
    }
}
