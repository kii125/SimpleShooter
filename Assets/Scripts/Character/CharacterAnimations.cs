using System;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void animator(float horizontal, float vertical)
    {
        _animator.SetFloat("Horizontal", Mathf.Lerp(_animator.GetFloat("Horizontal"), horizontal,2));
        _animator.SetFloat("Vertical", Mathf.Lerp(_animator.GetFloat("Vertical"), vertical,2));
    }
    
}
