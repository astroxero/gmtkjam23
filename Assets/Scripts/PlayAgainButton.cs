using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public CanvasElementVisibility bigText;
    public CanvasElementVisibility smallText;
    public CanvasElementVisibility button;
    public CanvasElementVisibility relo;
    public PlayerMove player;
    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
            relo.Visible = true;
            smallText.Visible = true;
            bigText.Visible = false;
            button.Visible = false;
        }
        
    }

    public void reloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            relo.Visible = false;
            smallText.Visible = false;
            bigText.Visible = true;
            button.Visible = true;
        }
    }
}
