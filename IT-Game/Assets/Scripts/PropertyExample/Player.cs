using UnityEngine;

namespace ScriptProperty
{
    public class Player : MonoBehaviour
    {
        public float Speed => _speed;
        public float JumpForce => _jumpForce;

        [SerializeField] private float _speed;
        [SerializeField] private float _jumpForce;
    }
}