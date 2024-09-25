using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSFX : MonoBehaviour
{
    public AudioClip windSFX;
    public float length = 5f;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayWindSound()
    {
        audioSource.PlayOneShot(windSFX);
        StartCoroutine(StopWaterDropSFX());
    }

    IEnumerator StopWaterDropSFX()
    {
        yield return new WaitForSeconds(length);
        audioSource.Stop();
    }
}
