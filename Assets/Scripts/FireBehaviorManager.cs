using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviorManager : MonoBehaviour
{
    public float maxSize;
    public float minSize;
    public float growthSpeed;
    public bool direction; //true = grow false = shrink
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.z > maxSize)
        {
            direction = false;
        }

        if (transform.localScale.z < minSize)
        {
            direction = true;
        }

        if (direction == true)
        {
            transform.localScale += new Vector3(0, 0, growthSpeed);
        }

        else
        {
            transform.localScale -= new Vector3(0, 0, growthSpeed);
        }
    }
}
