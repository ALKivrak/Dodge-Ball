using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private int times = 0;
    [SerializeField]
    private GameObject ball;

    private GameObject spawnedBall;

    [SerializeField]
    private Transform bottomLeft, bottomRight, topLeft, topRight;

    private int randomCorner;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    IEnumerator SpawnBall()
    {
        while (times < 50)
        {
            yield return new WaitForSeconds(10);

            randomCorner = Random.Range(1, 4);

            spawnedBall = Instantiate(ball);

            if (randomCorner == 1)
            {
                
                spawnedBall.transform.position = bottomLeft.position;
            }
            else if(randomCorner == 2)
            {
                spawnedBall.transform.position = topLeft.position;
                spawnedBall.GetComponent<BallMovement>().y = -20;
            }
            else if (randomCorner == 3)
            {
                spawnedBall.transform.position = bottomRight.position;
                spawnedBall.GetComponent<BallMovement>().x = -20;
            }
            else
            {
                spawnedBall.transform.position = bottomRight.position;
                spawnedBall.GetComponent<BallMovement>().x = -20;
                spawnedBall.GetComponent<BallMovement>().y = -20;
            }
            times += 1;
        }
    }
}
