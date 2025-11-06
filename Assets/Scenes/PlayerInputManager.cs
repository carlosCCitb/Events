using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour , InputControllers.IPlayerActions
{
    private InputControllers ic;
    private void Awake()
    {
        ic = new InputControllers();
        ic.Player.SetCallbacks(this);
    }
    private void OnEnable()
    {
        ic.Enable();
    }
    private void OnDisable()
    {
        ic.Disable();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
            Debug.Log("Jump performed");
        else if (context.canceled)
            Debug.Log("Jump Cancelled");
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (context.performed)
            Debug.Log("Assignem al animator i la direcció del player" + context.ReadValue<Vector2>());
        else if (context.canceled)
            Debug.Log("Assignem a la direcció del player " + context.ReadValue<Vector2>());
    }

}
