using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour
{
    public GameObject treePrefab;
    public float timeToSpawn;
    public float totalTime;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = 0;
    }

    private void spawnTree()
    {
        GameObject newTree = Instantiate(treePrefab) as GameObject;
        newTree.transform.position = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToSpawn > 0)
        {
            timeToSpawn -= Time.deltaTime;
        } else
        {
            timeToSpawn = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timeToSpawn == 0)
            {
                spawnTree();
                timeToSpawn = totalTime;
            }
        }
    }
}
