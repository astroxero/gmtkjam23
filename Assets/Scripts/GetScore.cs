using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    public TextMeshProUGUI smallText;
    public TextMeshProUGUI smallHighText;
    public TextMeshProUGUI bigText;
    public TextMeshProUGUI bigHighText;
    public DroneDeploy dd;

    float currentScore;
    public string currentScoreText;

    float highScore;
    public string highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void setCurrentScore()
    {
        currentScore = Mathf.Floor(dd.timeCounter);
        currentScoreText = currentScore.ToString();
    }

    void setHighScore()
    {
        if (currentScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", currentScore);
        }
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        highScoreText = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        setCurrentScore();
        setHighScore();

        smallText.text ="Score: " + currentScoreText + " sec.";
        smallHighText.text = "High Score: " + highScoreText + " sec.";
        bigText.text = "Score: " + currentScoreText + " sec.";
        bigHighText.text = "High Score: " + highScoreText + " sec.";

    }
}
