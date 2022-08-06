using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;

    float randomHorizontal;
    float randomVertical;

    [HideInInspector]
    public int x, y;

    Vector2 randomDirection;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        x = 20;
        y = 20;
        rb = GetComponent<Rigidbody2D>();
        pushBall();
    }

    public void pushBall()
    {
        rb.AddForce(new Vector2(x  * moveSpeed, y  * moveSpeed));
    }
}
