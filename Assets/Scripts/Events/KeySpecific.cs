using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeySpecific : MonoBehaviour, ICollectable
{
    public event Action<bool> pickedSpecificKey = delegate{};
    public void Collected(bool b)
    {
        pickedSpecificKey.Invoke(b);
    }

}
