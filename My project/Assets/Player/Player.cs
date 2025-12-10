using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    private Transform _tf;
    private PlayerInput _playerInput;
    private void Awake()
    {
        GetComponent();
        Init();
    }
    private void GetComponent()
    {
        _tf = GetComponent<Transform>();
    }
    private void Init()
    {
        
    }
}
