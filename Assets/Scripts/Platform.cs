using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour, IDisposer
{
    public void Dispose(GameObject obj)
    {
        obj.SetActive(true);
        //obj.GetComponent<ICollectable>().Collected(false);
        obj.GetComponent<BoxCollider2D>().enabled = false;
    }
}
