using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public CanvasElementVisibility button;
    public PlayerMove player;
    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
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
            print("player Dead");
            button.Visible = true;
        }
    }
}
