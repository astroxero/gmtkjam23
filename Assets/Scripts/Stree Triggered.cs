using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreeTriggered : MonoBehaviour
{
    AudioSource audioSource;
    public float lifeLeft;
    public float totalLife = 3f;

    // Start is called before the first frame update
    void Start()
    {
        lifeLeft = totalLife;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Drone")
        {
            Destroy(collision.gameObject);
            lifeLeft--;
            audioSource.PlayOneShot(audioSource.clip,1.0F);

            if (lifeLeft <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
