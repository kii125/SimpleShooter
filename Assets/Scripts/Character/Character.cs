using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterData _data;

    public CharacterData Data => _data;
}
