using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTriggered : MonoBehaviour
{
    public delegate void CoroutineCallback();

    public event CoroutineCallback OnWaitDroneComplete;
    public event CoroutineCallback OnWaitTreeComplete;

    AudioSource audioSource;
    public float lifeLeft;
    public float totalLife = 3f;
    public float droneWaitTime = 0.2f;
    public float treeWaitTime = 1f;
    private GameObject collidedDrone;

    // Start is called before the first frame update
    void Start()
    {
        lifeLeft = totalLife;
        audioSource = GetComponent<AudioSource>();

        OnWaitDroneComplete += HandleWaitDroneComplete;
        OnWaitTreeComplete += HandleWaitTreeComplete;
    }

    private void HandleWaitDroneComplete()
    {
        if (collidedDrone != null)
        {
            Destroy(collidedDrone);
            collidedDrone = null; // Reset the variable
        }
    }

    private void HandleWaitTreeComplete()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Drone")
        {
            lifeLeft--;
            audioSource.PlayOneShot(audioSource.clip, 1.0F);
            if ((lifeLeft > 0) && (lifeLeft != 0.5))
            {
                StartCoroutine(waitDrone());
                collidedDrone = collision.gameObject;
            } else if (lifeLeft <= 0)
            {
                StartCoroutine(waitDrone());
                collidedDrone = collision.gameObject;
                StartCoroutine(waitTree());
            }
        }
    }

    IEnumerator waitDrone()
    {
        yield return new WaitForSeconds(droneWaitTime);
        OnWaitDroneComplete?.Invoke();
    }
    IEnumerator waitTree()
    {
        yield return new WaitForSeconds(treeWaitTime);
        OnWaitTreeComplete?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeLeft <= 0)
        {
            StartCoroutine(waitTree());
            lifeLeft = 0.5f;
        }
    } 

}