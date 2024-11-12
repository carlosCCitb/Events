using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateGeneral : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        KeyGeneral.OnGetKey += Activate;
    }
    private void OnDisable()
    {
        KeyGeneral.OnGetKey -= Activate;
    }
    private void Activate(bool act)
    {
        _animator.SetBool("Open", act);
    }
}
