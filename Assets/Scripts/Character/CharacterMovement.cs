using System;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour, IMovable
{
    [SerializeField] private Character _character;

    private CharacterController _controller;

    public UnityEvent<float, float> OnChangePosition;
    public bool isRun;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private float _targetVelosity = 0;
    public void Move(Vector2 moveDirection)
    {
        OnChangePosition.Invoke(moveDirection.x, moveDirection.y);
        Vector3 moveDirectionVector3 = new Vector3(moveDirection.x, 0f, moveDirection.y);

        _targetVelosity = isRun ? _character.Data.RunSpeed : _character.Data.MoveSpeed;

        if (moveDirectionVector3 == Vector3.zero)
            _targetVelosity = 0f;

        if (_targetVelosity != 0)
        {
            Vector3 move = transform.right * moveDirectionVector3.x + transform.forward * moveDirectionVector3.z;
            _controller.Move(move * _targetVelosity * Time.deltaTime);
        }
    }
}
