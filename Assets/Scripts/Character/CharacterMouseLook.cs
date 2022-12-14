using System;
using UnityEngine;

public class CharacterMouseLook : MonoBehaviour, IMouseLook
{
    [SerializeField] private Character _character;
    [SerializeField] private Transform _cameraPivot;

    private float _yRotation = 0f;

    public void MouseLook(Vector2 MouseDelta)
    {
        transform.Rotate(Vector3.up, MouseDelta.x * _character.Data.LookSensitivity * Time.deltaTime);

        _yRotation -= MouseDelta.y * _character.Data.LookSensitivity * Time.deltaTime;
        _yRotation = Mathf.Clamp(_yRotation, -_character.Data.RotationClamp, _character.Data.RotationClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = _yRotation;
        _cameraPivot.eulerAngles = targetRotation;
    }
}
