using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsForThePlayer : MonoBehaviour
{
    private PlayerInput _pi;
    private void Awake()
    {
        _pi = GetComponent<PlayerInput>();
    }
    private void OnEnable()
    {
        _pi.actions["Jump"].performed += ctx => JumpPerformed(ctx);
        _pi.actions["Jump"].canceled += ctx => JumpCancelled(ctx);


    }
    private void OnDisable()
    {
        _pi.actions["Jump"].performed -= ctx => JumpPerformed(ctx);
        _pi.actions["Jump"].canceled -= ctx => JumpCancelled(ctx);

    }
    private void JumpPerformed(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jump Performed");
    }
    private void JumpCancelled(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jump Cancelled");
    }
}
