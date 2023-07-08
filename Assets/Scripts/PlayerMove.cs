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
        if ((Input.GetKey(KeyCode.W) ) || (Input.GetKey(KeyCode.UpArrow)))
        {
            rb.AddForce(transform.up * speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.UpArrow)))
        {
            anim.SetBool("isRunning", false);
        }
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            rb.AddForce(transform.right * speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.RightArrow)))
        {
            anim.SetBool("isRunning", false);
        }
        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            rb.AddForce(transform.up * -speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.DownArrow)))
        {
            anim.SetBool("isRunning", false);
        }
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            rb.AddForce(transform.right * -speed);
            anim.SetBool("isRunning", true);
        }
        if ((Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.LeftArrow)))
        {
            anim.SetBool("isRunning", false);
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
