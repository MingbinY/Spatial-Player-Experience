using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteractEvent;
    public bool canInteract = true;

    public string interactionHintText = "";

    public void TriggerInteractEvent()
    {
        if (canInteract)
        {
            onInteractEvent.Invoke();
        }
    }
}
