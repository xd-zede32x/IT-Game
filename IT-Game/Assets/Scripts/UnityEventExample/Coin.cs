using UnityEngine;
using ScriptsPlayer;

namespace ScriptsUnityEvent
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int _maxReward;
        [SerializeField] private int _minReward;

        private int _reward;

        private void Start() => _reward = Random.Range(_minReward, _maxReward);

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerMovement player))
            {
                EventManager.CallCoinPickedUp(_reward);
                Destroy(gameObject);
            }
        }
    }
}