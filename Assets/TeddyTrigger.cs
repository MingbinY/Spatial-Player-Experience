using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyTrigger : MonoBehaviour
{
    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return; 
        if (other.GetComponent<PlayerMovement>() != null)
        {
            GetComponent<AudioSource>().Play();
            triggered = true;
        }
    }
}
