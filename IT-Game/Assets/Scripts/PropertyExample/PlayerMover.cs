using UnityEngine;

namespace ScriptProperty
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void Update() => PlayerMovement();

        private void PlayerMovement() => transform.Translate(Vector3.forward * _player.Speed * Time.deltaTime);
    }
}