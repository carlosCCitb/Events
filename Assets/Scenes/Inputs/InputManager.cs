using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, InputActions.IAM1Actions
{
    //private PlayerInput pi;

    private InputActions ia;

    private void Awake()
    {
        //pi = GetComponent<PlayerInput>();
       
        ia = new InputActions();
        ia.AM1.SetCallbacks(this); //permite que JumpBehaviour maneje los eventos de entrada
                                   //definidos en el mapa de acciones AM1.
    }
    private void OnEnable()
    {
        /*pi.actions["Jump"].performed += ctx => JumpPerformed(ctx);
        pi.actions["Jump"].canceled += ctx => JumpCancelled();
        pi.actions["Jump"].started += ctx => JumpStarted();*/
        ia.AM1.Enable();

    }
    private void OnDisable()
    {
        /*pi.actions["Jump"].performed -= ctx => JumpPerformed(ctx);
        pi.actions["Jump"].canceled -= ctx => JumpCancelled();
        pi.actions["Jump"].started -= ctx => JumpStarted();*/
        ia.AM1.Disable();

    }
    private void Update()
    {
        //Vector2 direction = pi.actions["Movement"].ReadValue<Vector2>();
        //Debug.Log("direction: " + direction.x + direction.y);
    }
    private void JumpPerformed(InputAction.CallbackContext ctx)
    {
        Debug.Log("jumping performed");
    }
    private void JumpStarted()
    {
        Debug.Log("jumping started");
    }
    private void JumpCancelled()
    {
        Debug.Log("jumping cancelled");
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
            Debug.Log("Interface JumpPerformed");
        if(context.canceled)
            Debug.Log("Interface JumpCancelled");

    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<Vector2>());
        if (context.canceled)
            Debug.Log(new Vector2(0, 0));
    }
}
