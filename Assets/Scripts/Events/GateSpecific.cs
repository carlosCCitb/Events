using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSpecific : MonoBehaviour
{
    private Animator _animator;
    public KeySpecific key;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        key.pickedSpecificKey += OpenDoor;
    }
    private void OnDisable()
    {
        key.pickedSpecificKey -= OpenDoor;
    }

    private void OpenDoor(bool b)
    {
        _animator.SetBool("Open", b);
    }
}
