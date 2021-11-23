using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrapInteraction : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trap")
        {
            gameObject.SetActive(false);
        }
    }
}
