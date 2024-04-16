using TMPro;
using UnityEngine;
using ScriptsGameObjects;

namespace ScriptInterface
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreView : MonoBehaviour
    {
        private TextMeshProUGUI _scoreText;
        private int _score = 0;

        private void Start()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
            EventManager.EnemyDied += OnEnemyDied;
        }

        private void OnDestroy() => EventManager.EnemyDied -= OnEnemyDied;

        private void OnEnemyDied()
        {
            _score++;
            _scoreText.text = $"Score: {_score}";
        }
    }
}