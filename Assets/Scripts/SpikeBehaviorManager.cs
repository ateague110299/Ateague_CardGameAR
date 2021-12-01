using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviorManager : MonoBehaviour
{
    public float startPoint;
    public float endPoint;
    public float shiftSpeed;
    public bool direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > endPoint)
        {
            direction = false;
        }

        if (transform.position.y < startPoint)
        {
            direction = true;
        }

        if (direction == true)
        {
            transform.localPosition -= new Vector3(0, shiftSpeed, 0);
        }

        else
        {
            transform.localPosition += new Vector3(0, shiftSpeed, 0);
        }
    }
}
