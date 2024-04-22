using System;
using UnityEngine;
using ScriptsHealthBar;
using UnityEngine.Events;

namespace ScriptHealthBar
{
    public class Health : MonoBehaviour, IDamageable
    {
        private readonly int DAMAGE_PLAYER = 5;

        public event UnityAction<float> HealthChanged;
        public IntEvent Hit = new IntEvent();

        [SerializeField] private int _maxHealth;

        private int _currentHealth;

        private void Start() => _currentHealth = _maxHealth;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                ApplyDamage(DAMAGE_PLAYER);
        }

        public void ApplyDamage(int damageValue)
        {
            if (damageValue > 0)
            {
                _currentHealth -= damageValue;
                Hit?.Invoke(damageValue);

                if (_currentHealth <= 0)
                    Death();

                else
                {
                    float currentHealthAsPercentage = (float)_currentHealth / _maxHealth;
                    HealthChanged?.Invoke(currentHealthAsPercentage);
                }
            }

            else
                throw new NullReferenceException(nameof(damageValue));
        }

        private void Death() => HealthChanged?.Invoke(0f);
    }
}