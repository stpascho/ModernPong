using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int randomNumber;
    public float velocityX;
    public float velocityY;
    public Rigidbody2D rigidbodyBall;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyBall = GetComponent<Rigidbody2D>();
        randomNumber = Random.Range(2, 3);
        if (randomNumber == 3)
        {
            rigidbodyBall.AddForce(new Vector2(80, 10));
        }
        else
        {
            rigidbodyBall.AddForce(new Vector2(-100, -10));
        }

    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {

        if (colInfo.collider.CompareTag("Player"))
        {
            velocityY = rigidbodyBall.velocity.y;
            velocityX = rigidbodyBall.velocity.x;
            rigidbodyBall.velocity = new Vector2(rigidbodyBall.velocity.x, velocityY / 2 + colInfo.collider.attachedRigidbody.velocity.y / 3);
        }
    }
}