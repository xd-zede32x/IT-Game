using System;
using UnityEngine;
using ScriptInterface;
using UnityEngine.Events;

namespace ScriptsGameObjects
{
    public abstract class BaseEnemy : MonoBehaviour, IDamageable
    { 

        [SerializeField] private int _maxHealth;

        private int _currentHealth;

        private void Awake() => _currentHealth = _maxHealth;

        public void ApplyDamage(int damageValue)
        {
            if (damageValue <= 0)
                throw new ArgumentNullException(nameof(damageValue));

            _currentHealth -= damageValue;

            if (_currentHealth <= 0)
            {
                EventManager.OnEnemyDied();

                Debug.Log("Враг повержен");
                gameObject.SetActive(false);

            }
        }
    }
}