using TMPro;
using UnityEngine;

namespace ScriptsUI 
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private string _template;

        private TextMeshProUGUI _scoreText;

        private void Awake() => _scoreText = GetComponent<TextMeshProUGUI>();

        public void SetScore(int score) => _scoreText.text = string.Format(_template, score);
    }
}