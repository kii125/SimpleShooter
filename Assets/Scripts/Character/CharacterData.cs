using UnityEngine;

[CreateAssetMenu(fileName = "New Character Data", menuName = "Character/Data", order = 61)]
public class CharacterData : ScriptableObject
{
    [Header("Movement")] [Space(2)]
    [SerializeField] private float _moveSpeed = 10;
    [SerializeField] private float _runSpeed = 15;
    [SerializeField] private float _lerpSpeed = 1;

    [Space(5)] [Header("Jump and gravity")] [Space(2)]
    [SerializeField] private float _jumpForce = 9;

    [SerializeField] private float _gravityForce = 8.9f;

    [Space(5)] [Header("Mouse look")] [Space(2)] 
    [SerializeField] private float _lookSensitivity;
    [SerializeField] private int _rotationClamp;
    
    
    
    //getters of movement
    public float MoveSpeed => _moveSpeed;
    public float RunSpeed => _runSpeed;
    public float LerpSpeed => _lerpSpeed;
    
    //getters of Jump and gravity
    public float JumpForce => _jumpForce;
    public float GravityForce => _gravityForce;
    
    //getters of Mouse look
    public float LookSensitivity => _lookSensitivity;
    public int RotationClamp => _rotationClamp;
    
}
