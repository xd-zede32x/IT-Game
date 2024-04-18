using UnityEngine;
using UnityEngine.Events;

namespace ScriptHealthBar
{
    public class Health : MonoBehaviour
    {
        public event UnityAction<float> HealthChanged;

        [SerializeField, Header("HealthStats")] private int _maxHealth = 100;

        private int _currentHealth;

        private void Start() => _currentHealth = _maxHealth;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                ChangeHealth(-10);
        }

        private void ChangeHealth(int value)
        {
            _currentHealth += value;

            if (_currentHealth <= 0)
                Death();

            else
            {
                float currentHealthAsPercentage = (float)_currentHealth / _maxHealth;
                HealthChanged?.Invoke(currentHealthAsPercentage);
            }
        }

        private void Death()
        {
            HealthChanged?.Invoke(0f);
            Debug.Log("YOU ARE DEATH:)");
        }
    }
}