using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void turnRight()
    {
        rb.transform.localScale = new Vector3(1, 1, 1);
    }

    public void turnLeft()
    {
        rb.transform.localScale = new Vector3(-1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.up * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            turnLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            turnRight();
        }
    }
}
