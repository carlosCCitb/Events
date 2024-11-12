using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyGeneral : MonoBehaviour, ICollectable
{
    public static event Action<bool> OnGetKey = delegate { }; //STATIC
    public void Collected()
    {
        Collected(true);
        gameObject.SetActive(false);
    }
    public void Collected(bool f)
    {
        OnGetKey.Invoke(f);
    }
}
