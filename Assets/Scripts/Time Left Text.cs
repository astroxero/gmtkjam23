using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeLeftText : MonoBehaviour
{
    public TreeSpawn tss;
    public string tls;
    public TextMeshProUGUI tmp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tls = Mathf.Floor(tss.timeToSpawn).ToString();
        tmp.text = tls;
    }
}
