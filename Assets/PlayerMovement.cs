using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public Rigidbody2D rigidbody2D;

    public float speed = 10;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rigidbody2D.velocity = new Vector3(0, speed, 0);
        }

        else if (Input.GetKey(moveDown))
        {
            rigidbody2D.velocity = new Vector3(0, -1 * speed, 0);
        }
        else
        {
            rigidbody2D.velocity = new Vector3(0, 0, 0);
        }

    }
}
