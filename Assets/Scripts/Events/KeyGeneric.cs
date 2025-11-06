using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyGeneric : MonoBehaviour, ICollectable
{
    public static event Action<bool> pickedGenericKey = delegate { };
    public void Collected(bool b)
    {
        pickedGenericKey.Invoke(b);
    }
}
