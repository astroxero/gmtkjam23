using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFlySound : MonoBehaviour
{
    AudioClip theClip;
    AudioSource audioSource;
    float randomNumber;
    public AudioClip drone_1;
    public AudioClip drone_2;
    public AudioClip drone_3;
    public AudioClip drone_4;
    public AudioClip drone_5;
    public AudioClip drone_6;
    public AudioClip drone_7;
    public float audioDroneFlyVol;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        randomNumber = Random.Range(1,7);
        switch (randomNumber)
        {
            case(1):
                theClip = drone_1;
                break;
            case(2):
                theClip = drone_2;
                break;
            case(3):
                theClip = drone_3;
                break;
            case(4):
                theClip = drone_4;
                break;
            case(5):
                theClip = drone_5;
                break;
            case(6):
                theClip = drone_5;
                break;
            case(7):
                theClip = drone_6;
                break;
            default:
                theClip = null;
                break;
        }
        // clipName = drone_Name + randomNumber.ToString();
        audioSource.PlayOneShot(theClip, audioDroneFlyVol);
    }

    void update()
    {
        // nothing
    }
}

    
    
    
    
    
    
    
    
    // Start is called before the first frame update