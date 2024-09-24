using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Door : MonoBehaviour
{
    bool triggered = false;
    public List<GameObject> objectsToShow;
    public GameObject lightToTurnOff;

    public AudioClip doorShakeClip;
    public AudioSource doorSource;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;
        if (other.GetComponent<PlayerMovement>())
        {
            triggered = true;
            foreach (GameObject obj in objectsToShow)
            {
                obj.SetActive(true);
            }

            MaterialChanger[] matChangers = FindObjectsOfType<MaterialChanger>();
            foreach (MaterialChanger changer in matChangers)
            {
                changer.ShowBloodMat();
            }

            lightToTurnOff.SetActive(false);
            FindObjectOfType<CeilingLightFlash>().isFlashing = true;
            doorSource.PlayOneShot(doorShakeClip);
        }
    }
}
