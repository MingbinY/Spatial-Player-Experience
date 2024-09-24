using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material noBloodMat;
    public Material bloodMat;
    private void Awake()
    {
        if (noBloodMat != null)
            GetComponent<MeshRenderer>().material = noBloodMat;
    }
    public void ShowBloodMat()
    {
        if (bloodMat != null)
            GetComponent<MeshRenderer>().material = bloodMat;
    }
}
