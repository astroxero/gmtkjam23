using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(60, 130);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.right * speed);
    }
}
