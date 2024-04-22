using System;
using UnityEngine;

namespace ScriptsPlayer
{
    public class PlayerMovement : MonoBehaviour
    {
        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";

        [SerializeField] private float _speed;

        private void Update() => Move();

        private void Move()
        {
            if (_speed > 0)
            {
                float horizontal = Input.GetAxis(HORIZONTAL);
                float vertical = Input.GetAxis(VERTICAL);

                Vector3 movement = new Vector3(horizontal, 0f, vertical);

                transform.Translate(movement * _speed * Time.deltaTime);
            }

            else
                throw new NullReferenceException(nameof(_speed));
        }
    }
}