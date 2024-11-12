using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSpecific : MonoBehaviour
{
    private Animator _animator;
    public KeySpecific _keySpecific;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        _keySpecific.OnGetKey += Activate;
    }
    private void OnDisable()
    {
        _keySpecific.OnGetKey -= Activate;
    }
    private void Activate(bool act)
    {
        _animator.SetBool("Open", act);
    }
}
