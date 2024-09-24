using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    public Text interactionText;
    Interactor interactor;

    private void Start()
    {
        interactor = FindObjectOfType<Interactor>();
    }

    private void FixedUpdate()
    {
        UpdateInteractionText();
    }

    private void UpdateInteractionText()
    {
        if (!interactor.HasInteractable())
        {
            interactionText.text = "";
            return;
        }

        interactionText.text = "Press E to " + interactor.GetInteractableHint();
    }
}
