using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateGeneric : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        KeyGeneric.pickedGenericKey += OpenDoor;
    }
    private void OnDisable()
    {
        KeyGeneric.pickedGenericKey -= OpenDoor;
    }
    public void OpenDoor(bool b)
    {
        _animator.SetBool("Open", b);
    }
}
