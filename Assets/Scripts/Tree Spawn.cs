using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour
{
    public GameObject treePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void spawnTree()
    {
        GameObject newTree = Instantiate(treePrefab) as GameObject;
        newTree.transform.position = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnTree();
        }
    }
}
