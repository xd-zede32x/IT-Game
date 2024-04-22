using System;
using UnityEngine.Events;

namespace ScriptsUnityEvent
{
    public class EventManager
    {
        public static readonly UnityEvent<int> CoinPickedUp = new UnityEvent<int>();

        public static void CallCoinPickedUp(int reward)
        {
            if (CoinPickedUp != null)
                CoinPickedUp?.Invoke(reward);

            else
                throw new NullReferenceException("CoinPickedUp == null");
        }
    }
}