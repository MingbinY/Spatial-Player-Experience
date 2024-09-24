using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingLightFlash : MonoBehaviour
{
    public bool isFlashing = false;

    public float minInterval = 0.2f;
    public float maxOnInterval = 2f;
    public float maxOffInterval = 2f;
    float nextFlashTime = 0;
    bool isOff = false;

    public GameObject lightSource;

    private void Start()
    {
        lightSource.SetActive(true);
        nextFlashTime = Random.Range(minInterval, maxOnInterval);
    }

    private void Update()
    {
        if (!isFlashing) { return; }
        if (Time.time >=nextFlashTime)
            Flash();
    }

    void Flash()
    {
        if (isOff)
        {
            lightSource.SetActive(true);
            nextFlashTime = Time.time + Random.Range(minInterval, maxOnInterval);
            isOff = false;
        }
        else
        {
            lightSource.SetActive(false);
            nextFlashTime = Time.time + Random.Range(minInterval, maxOffInterval);
            isOff = true;
        }
    }
}
