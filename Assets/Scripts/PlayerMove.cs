using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public float speed = 0;
    
    bool keyUp = false;
    bool keyDown = false;
    bool keyLeft = false;
    bool keyRight = false;
    bool isRunning = false;


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
    void FixedUpdate()
    {
        if ((Input.GetKey(KeyCode.W) ) || (Input.GetKey(KeyCode.UpArrow)))
        {
            keyUp = true;
        } else {keyUp = false;};

        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            keyDown = true;
        } else {keyDown = false;};

        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            keyRight = true;
        } else {keyRight = false;};

        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            keyLeft = true;
        } else {keyLeft = false;};

        isRunning = false;

        if (keyLeft) {
            turnLeft();
            isRunning = true;
            rb.AddForce(transform.right * -speed);
        }      

        if (keyRight) {
            turnRight();
            isRunning = true;
            rb.AddForce(transform.right * speed);
        }  

        if (keyUp) {
            isRunning = true;
            rb.AddForce(transform.up * speed);
        }

        if (keyDown) {
            isRunning = true;
            rb.AddForce(transform.up * -speed);
        }

        if (isRunning) {
            anim.SetBool("isRunning", true);
        } else { 
            anim.SetBool("isRunning", false);
        }
    }
}
