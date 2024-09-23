using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public float interactionDist = 5f;
    Interactable hitInteractable = null;

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactionDist))
        {
            hitInteractable = hit.collider.GetComponent<Interactable>();
        }
        else
        {
            hitInteractable = null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (hitInteractable != null)
                hitInteractable.TriggerInteractEvent();
        }
    }

    public bool HasInteractable()
    {
        return hitInteractable != null && hitInteractable.canInteract;
    }

    public string GetInteractableHint()
    {
        return hitInteractable != null ? hitInteractable.interactionHintText : string.Empty;
    }
}
