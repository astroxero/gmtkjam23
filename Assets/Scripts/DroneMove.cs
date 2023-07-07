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
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * speed);
        if (transform.position.x > screenBounds.x + 5)
        {
            Destroy(this.gameObject);
        }
    }
}
