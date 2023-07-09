using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeLeftText : MonoBehaviour
{
    public TreeSpawn tss;
    public string tls;
    public float tlf;
    public TextMeshProUGUI tmp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tlf = Mathf.Ceil(tss.timeToSpawn);
        tls = tlf.ToString();

        if (tlf != 0) {
            tmp.text = "Place tree in " + tls + " sec.";
            tmp.faceColor = new Color32(219, 132, 0, 255);
        } else {
            tmp.text = "Place tree now.";
            tmp.faceColor = new Color32(14, 255, 0, 255);
        }
        
    }
}
