using UnityEngine;
using UnityEngine.UI;

namespace ScriptHealthBar
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Health _health;
        [SerializeField] private Gradient _gradient;
        [SerializeField] private Image _healthBarFilling;

        private void Awake() => _health.HealthChanged += OnHealthChanged;

        private void OnDestroy() => _health.HealthChanged -= OnHealthChanged;

        private void OnHealthChanged(float valueAsPercantage)
        {
            _healthBarFilling.fillAmount = valueAsPercantage;
            _healthBarFilling.color = _gradient.Evaluate(valueAsPercantage);
        }
    }
}