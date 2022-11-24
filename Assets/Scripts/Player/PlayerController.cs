using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private int angle;
    [SerializeField] private int maxAngle;
    [SerializeField] private int minAngle;

    private Vector3 startPos;
    private Rigidbody2D rb;
    
    private void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    
    
    private void Update()
    {
        if (GameController.isGameOver)
        {
            return;
        }
        
        Rotate();
        Jump();
    }

    private void Jump()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
        }
    }

    private void Rotate()
    {
        if (rb.velocity.y > 0 && angle <= maxAngle)
        {
            angle += 4;
        }
        else if (rb.velocity.y < -3f && angle>minAngle)
        {
            angle -= 2;
        }
        
        transform.rotation = Quaternion.Euler(0,0,angle);
    }

    

    
}
