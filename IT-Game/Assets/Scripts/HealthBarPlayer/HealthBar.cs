using UnityEngine;
using UnityEngine.UI;

namespace ScriptHealthBar
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Image _healthBarFilling;
        [SerializeField] private Health _health;
        [SerializeField] private Gradient _gradient;

        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
            _health.HealthChanged += OnHealthChanged;
        }

        private void OnDestroy() => _health.HealthChanged -= OnHealthChanged;

        private void OnHealthChanged(float valueAsPercantage)
        {
            Debug.Log(valueAsPercantage);
            _healthBarFilling.fillAmount = valueAsPercantage; 
            _healthBarFilling.color = _gradient.Evaluate(valueAsPercantage);
        }
    }
}