using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Bed : MonoBehaviour
{
    bool triggered = false;
    public GameObject volumeLight;
    public List<GameObject> lightToTurnOff;
    public Material lightBulbMat;
    public MeshRenderer lampRenderer;
    public GameObject bearTrigger;
    public GameObject bloodBed;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.GetComponent<PlayerMovement>() != null)
        {
            triggered = true;
            volumeLight.SetActive(true);

            FindObjectOfType<ToyCar>().TriggerMove();

            StartCoroutine(doorOpenWait());

            foreach (GameObject light in lightToTurnOff)
            {
                light.SetActive(false);
            }

            lampRenderer.material = lightBulbMat;
        }
    }

    IEnumerator doorOpenWait()
    {
        yield return new WaitForSeconds(3f);
        FindObjectOfType<ClosetDoor>().OpenDoor();
        bearTrigger.SetActive(true);
        bloodBed.SetActive(true);
    }
}
