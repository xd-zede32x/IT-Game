using System;
using UnityEngine;

namespace ScriptsEncapsulation
{
    public class Wallet : MonoBehaviour
    {
        public int Coins => _coins;
        public int MaxCoins => _maxCoins;

        [Header("Money")]

        [SerializeField] private int _coins;
        [SerializeField] private int _maxCoins;

        public Wallet(int maxCoins)
        {
            if (maxCoins <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxCoins));

            _maxCoins = maxCoins;
        }

        public bool IsEnoughSpace(int coins) => _coins + coins <= _maxCoins;

        public void AddCoins(int coins)
        {
            if (_maxCoins <= 0)
                throw new ArgumentOutOfRangeException(nameof(_maxCoins));

            _coins += coins;
        }
    }
}