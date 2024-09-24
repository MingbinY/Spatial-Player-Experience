using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : Interactable
{
    public Transform drawer;
    public Vector3 closePos;
    public Vector3 openPos;

    bool isOpened = false;

    public void ShelfOpenClose()
    {
        drawer.localPosition = isOpened ? closePos : openPos;
        isOpened = !isOpened;
    }
}
