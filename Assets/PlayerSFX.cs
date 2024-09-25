using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    public AudioClip momClip;
    public AudioClip doorClip;
    public AudioClip scream;

    public AudioSource audioSource;

    private void Start()
    {
        StartCoroutine(PlayMomSFX());
    }

    IEnumerator PlayMomSFX()
    {
        yield return new WaitForSeconds(1);
        PlaySFX(1);
    }

    public void PlaySFX(int index)
    {
        AudioClip clipToPlay = momClip;

        if (index == 1)
        {
            clipToPlay = momClip;
        }else if (index == 2)
        {
            clipToPlay = doorClip;
        }else if (index == 3)
        {
            clipToPlay = scream;
        }

        audioSource.PlayOneShot(clipToPlay);
    }
}
