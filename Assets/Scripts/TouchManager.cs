using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    private const string TOUCH_PRESS = "TouchPress";
    private const string TOUCH_POSITION = "TouchPosition";



    private PlayerInput playerInput;

    private InputAction touchPositionAction;
    private InputAction touchPressAction;


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        touchPressAction = playerInput.actions.FindAction(TOUCH_PRESS);
        touchPositionAction = playerInput.actions.FindAction(TOUCH_POSITION);
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }


    private void TouchPressed(InputAction.CallbackContext context)
    {
        Vector3 position = Camera.main.ScreenToWorldPoint
                           (touchPositionAction.ReadValue<Vector2>());
    }
}
