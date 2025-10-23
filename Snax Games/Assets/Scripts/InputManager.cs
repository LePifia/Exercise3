using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{
    public static InputManager instance { get; private set; }
    [SerializeField] private PlayerControler inputActions;

    public static Action OnMoveUp;
    public static Action OnMoveDown;
    public static Action OnMoveLeft;
    public static Action OnMoveRight;

    //Singleton pattern
    private void Awake()
    {
        if (instance != null) { Destroy(gameObject); return; }
        instance = this;

        // Initialize Input Actions
        inputActions = new PlayerControler();

        inputActions.Computer.Enable();
    }

    private void OnEnable()
    {
        inputActions.Computer.UpDirection.performed += OnUpDirection;
        inputActions.Computer.DownDirection.performed += OnDownDirection;
        inputActions.Computer.LeftDirection.performed += OnLeftDirection;
        inputActions.Computer.RightDirection.performed += OnRightDirection;
    }

    private void OnDisable()
    {
        inputActions.Computer.UpDirection.performed -= OnUpDirection;
        inputActions.Computer.DownDirection.performed -= OnDownDirection;
        inputActions.Computer.LeftDirection.performed -= OnLeftDirection;
        inputActions.Computer.RightDirection.performed -= OnRightDirection;
    }

    private void OnUpDirection(InputAction.CallbackContext context)
    {
        OnMoveUp?.Invoke();
        
        #if UNITY_EDITOR
        Debug.Log("Up Move Detected");
        #endif
    }

    private void OnDownDirection(InputAction.CallbackContext context)
    {
        OnMoveDown?.Invoke();

        #if UNITY_EDITOR
        Debug.Log("Down Move Detected");
        #endif
    }

    private void OnLeftDirection(InputAction.CallbackContext context)
    {
        OnMoveLeft?.Invoke();

        #if UNITY_EDITOR
        Debug.Log("Left Move Detected");
        #endif
    }

    private void OnRightDirection(InputAction.CallbackContext context)
    {
        OnMoveRight?.Invoke();

        #if UNITY_EDITOR
        Debug.Log("Right Move Detected");
        #endif
    }

    void OnDestroy()
    {
        inputActions.Computer.Disable();
    }

}

