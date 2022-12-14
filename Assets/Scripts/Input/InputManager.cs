using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public GameObject IMovableObject;
    public GameObject IMouseLookObject;

    private IMovable _iMovable;
    private IMouseLook _imouseLook;

    private CharacterInput _input;

    private void OnEnable() => _input.Enable(); 
    private void OnDisable() => _input.Disable();

    private void Awake()
    {
        _input = new CharacterInput();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        IMovableObject.TryGetComponent(out _iMovable);
        IMouseLookObject.TryGetComponent(out _imouseLook);
    }

    private void Update()
    {
        _iMovable.Move(_input.Player.Movement.ReadValue<Vector2>());
        _imouseLook.MouseLook(_input.Player.Mouse.ReadValue<Vector2>());
    }
}
