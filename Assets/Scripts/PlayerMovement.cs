using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private string BALL = "Ball";

    [Header("Movement")]
    public float moveSpeed;

    float horizontalInput;
    float verticalInput;

    Vector2 moveDirection;

    Rigidbody2D rb;

    public int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
        MyInput();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(horizontalInput, verticalInput);
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(BALL))
        {
            lives -= 1;
            Lives.strikes -= 1;

        }
            
    }

    
}

    