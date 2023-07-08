using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public StreeTriggered psts;
    public float lifeLeft;
    public float triggerMoment;
    // Start is called before the first frame update
    void Start()
    {
        lifeLeft = psts.lifeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        lifeLeft = psts.lifeLeft;
        if ((lifeLeft <= triggerMoment) || (psts == null))
        {
            Destroy(gameObject);
        }
    }
}
