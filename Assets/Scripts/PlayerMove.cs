using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
        {
            rb.AddForce(transform.up * speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            rb.AddForce(transform.right * speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            rb.AddForce(transform.up * -speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            rb.AddForce(transform.right * -speed);
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            turnLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            turnRight();
        }

        if ((!Input.GetKey(KeyCode.W)) && (!Input.GetKey(KeyCode.UpArrow)) && (!Input.GetKey(KeyCode.D)) && (!Input.GetKey(KeyCode.RightArrow)) && (!Input.GetKey(KeyCode.S)) && (!Input.GetKey(KeyCode.DownArrow)) && (!Input.GetKey(KeyCode.A)) || (!Input.GetKey(KeyCode.LeftArrow)))
        {
            anim.SetBool("isRunning", false);
        }
    }
}
