using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMaterial : MonoBehaviour
{
    public Material noBloodMat;
    public Material bloodMat;
    
    public void SwitchHorseMat()
    {
        GetComponent<MeshRenderer>().material = GetComponent<MeshRenderer>().material == noBloodMat ? bloodMat : noBloodMat;
    }
}
