using ScriptsUI;
using UnityEngine;

namespace ScriptsUnityEvent
{
    [RequireComponent(typeof(ScoreView))]
    public class Score : MonoBehaviour
    {
        private ScoreView _scoreView;

        private int _score;

        private void Awake() 
        {
            _scoreView = GetComponent<ScoreView>();

            EventManager.CoinPickedUp.AddListener(Increase);
        }

        private void Increase(int score)
        {
            _score += score;

            _scoreView.SetScore(_score);
        }   
    }
}