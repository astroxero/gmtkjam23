using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneDead : MonoBehaviour
{

    public CanvasElementVisibility txt;
    public PlayerMove player;
    public float dronesPassed;
    public TreeTriggered st;
    public AudioClip drone_got_through;
    public float audioDroneGotThruVol;
    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        txt.Visible = false;
        dronesPassed = 0;
        audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Drone")
        {
            
            if (player != null) {
                txt.Visible = true;
                audioSource.PlayOneShot(drone_got_through, audioDroneGotThruVol);
            }
            Destroy(collision.gameObject);
            st.lifeLeft--;
            yield return new WaitForSeconds(1f);
            txt.Visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
