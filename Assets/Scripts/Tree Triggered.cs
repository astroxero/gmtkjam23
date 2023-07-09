using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTriggered : MonoBehaviour
{
    public delegate void CoroutineCallback();

    public event CoroutineCallback OnWaitDroneComplete;

    public Animator anim;
    AudioSource audioSource;

    public float lifeLeft;
    public float totalLife = 3f;
    public float droneWaitTime = 0.2f;
    private GameObject collidedDrone;
    public AudioClip impact;
    public AudioClip tree_fall;
    public float audioImpactVol;
    public float audioTreeFallVol;

    // Start is called before the first frame update
    void Start()
    {
        lifeLeft = totalLife;
        audioSource = GetComponent<AudioSource>();

        OnWaitDroneComplete += HandleWaitDroneComplete;
    }

    private void HandleWaitDroneComplete()
    {
        if (collidedDrone != null)
        {
            Destroy(collidedDrone);
            collidedDrone = null; // Reset the variable
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Drone")
        {
            lifeLeft--;
            if (lifeLeft > 0)
            {
                anim.SetTrigger("isHit");
            }
            if (lifeLeft <= 0)
            {
                anim.SetTrigger("isDead");
                // trigger tree fall sound here
                audioSource.PlayOneShot(tree_fall, audioTreeFallVol);
                Destroy(GetComponent<TreeTriggered>());
                Destroy(GetComponent<PlayerMove>());
            }
            audioSource.PlayOneShot(impact, audioImpactVol);
            if (lifeLeft > 0)
            {
                StartCoroutine(waitDrone());
                collidedDrone = collision.gameObject;
            }
        }
    }

    IEnumerator waitDrone()
    {
        yield return new WaitForSeconds(droneWaitTime);
        OnWaitDroneComplete?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeLeft <= 0)
        {
            anim.SetTrigger("isDead");
            // trigger tree fall sound here
            audioSource.PlayOneShot(tree_fall, audioTreeFallVol);
            Destroy(GetComponent<TreeTriggered>());
            Destroy(GetComponent<PlayerMove>());
        }
    } 

}