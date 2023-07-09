using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    public DroneDeploy dd;
    public string scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText = Mathf.Floor(dd.timeCounter).ToString();
        textObject.text = "Score: " + scoreText + "sec.";
    }
}
