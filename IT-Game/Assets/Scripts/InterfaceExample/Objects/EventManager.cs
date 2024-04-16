using UnityEngine;
using UnityEngine.Events;

namespace ScriptsGameObjects
{
    public class EventManager : MonoBehaviour
    {
        public static event UnityAction EnemyDied;

        public static void OnEnemyDied() => EnemyDied?.Invoke();
    }
}