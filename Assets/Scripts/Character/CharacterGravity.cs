using System;
using UnityEngine;


public class CharacterGravity : MonoBehaviour
{
    [SerializeField] private Character _character;

    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!_controller.isGrounded)
        {
            _controller.Move(new Vector3(0f,_character.Data.GravityForce,0f) * Time.deltaTime);
        }
    }
}
