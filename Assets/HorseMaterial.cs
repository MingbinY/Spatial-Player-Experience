using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMaterial : MonoBehaviour
{
    public Material noBloodMat;
    public Material bloodMat;

    private void Start()
    {
        StartCoroutine(HorseTimer());
    }

    public void SwitchHorseMat()
    {
        GetComponent<MeshRenderer>().material = GetComponent<MeshRenderer>().material == noBloodMat ? bloodMat : noBloodMat;
    }

    IEnumerator HorseTimer()
    {
        yield return new WaitForSeconds(60f);
        SwitchHorseMat();
    }
}
