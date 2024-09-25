using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropSFX : MonoBehaviour
{
    public AudioClip waterDropClip;
    public float length = 5f;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayWaterDrop()
    {
        audioSource.PlayOneShot(waterDropClip);
        StartCoroutine(StopWaterDropSFX());
    }

    IEnumerator StopWaterDropSFX()
    {
        yield return new WaitForSeconds(length);
        audioSource.Stop();
    }
}
