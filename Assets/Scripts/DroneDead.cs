using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneDead : MonoBehaviour
{

    public float dronesPassed;
    public TreeTriggered st;

    // Start is called before the first frame update
    void Start()
    {
        dronesPassed = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Drone")
        {
            Destroy(collision.gameObject);
            st.lifeLeft--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
