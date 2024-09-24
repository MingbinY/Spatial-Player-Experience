using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetDoor : MonoBehaviour
{
    public Quaternion openRot;
    public AudioClip openSound;

    public void OpenDoor()
    {
        transform.localRotation = openRot;
        GetComponent<AudioSource>().PlayOneShot(openSound);
    }
}
