using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Bed : MonoBehaviour
{
    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.GetComponent<PlayerMovement>() != null)
        {
            triggered = true;
            FindObjectOfType<ToyCar>().TriggerMove();

        }
    }
}
