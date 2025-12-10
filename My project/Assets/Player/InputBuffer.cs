using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputBuffer : MonoBehaviour
{
    public void Awake()
    {
       PlayerInput player = GetComponent<PlayerInput>();
        _playerInput = player;
        _moveAction = player.actions[MOVEACTION];
        _selectAction = player.actions[SELECTACTION];
        _enterAction = player.actions[ENTERACTION];
        SetInput();

    }


    public event Action<Vector2> OnMove;
    public event Action<int> OnSelect;
    public event Action OnEnter;


    private PlayerInput _playerInput;

    private InputAction _moveAction;
    private InputAction _selectAction;
    private InputAction _enterAction;

    private const string MOVEACTION = "Move";
    private const string SELECTACTION = "Select";
    private const string ENTERACTION = "Enter";
    private void SetInput()
    {
        _moveAction.performed += InputMove;
        _moveAction.canceled += InputMove;
    }
    private void InputMove(InputAction.CallbackContext ctx)
    {
        Vector2 input = ctx.ReadValue<Vector2>();
        OnMove?.Invoke(input);
    }
}
