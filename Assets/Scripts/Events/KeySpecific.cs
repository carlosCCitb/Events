using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class KeySpecific : MonoBehaviour, ICollectable
{
    public event Action<bool> OnGetKey = delegate { }; //STATIC
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
