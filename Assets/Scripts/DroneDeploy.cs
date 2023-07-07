using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneDeploy : MonoBehaviour
{
    public GameObject dronePrefab;
    public float respawnTime = 1f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(droneWave());
    }

    private void spawnDrone()
    {
        GameObject newDrone = Instantiate(dronePrefab) as GameObject;
        newDrone.transform.position = new Vector2(screenBounds.x - 25, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator droneWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnDrone();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
