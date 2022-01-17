using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    private TouchControls _touchControls;
    private MouseKeyboardControls _mouseKeyboardControls;
    private PlayerMotion _playerMotion;

    private void Awake()
    {
        _touchControls = new TouchControls();
        _mouseKeyboardControls = new MouseKeyboardControls();
    }

    private void OnEnable()
    {
        _touchControls.Enable();
        _mouseKeyboardControls.Enable();
    }

    private void OnDisable()
    {
        _touchControls.Disable();
        _mouseKeyboardControls.Disable();
    }

    private void Start()
    {
        _playerMotion = FindObjectOfType<PlayerMotion>();
        
        _touchControls.Touch.TouchPress.started += context => EnableMovement(context);
        _touchControls.Touch.TouchRelease.canceled += context => DisableMovement(context);

        _mouseKeyboardControls.MouseKeyboard.LMBPress.started += context => EnableMovement(context);
        _mouseKeyboardControls.MouseKeyboard.LMBRelease.canceled += context => DisableMovement(context);
    }

    private void EnableMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Enabling movement");
        _playerMotion.SetIsMoving(true);
    }

    private void DisableMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Disabling movement");
        _playerMotion.SetIsMoving(false);
    }
}
