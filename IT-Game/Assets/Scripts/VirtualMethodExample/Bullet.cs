using UnityEngine;

namespace ScriptVirtualMethod
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void Update() => transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}