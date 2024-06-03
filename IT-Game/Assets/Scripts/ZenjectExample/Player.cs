using Zenject;
using UnityEngine;

namespace ScriptsZenject
{
    public class Player : MonoBehaviour, IMovable
    {
        public float Speed { get; private set; }

        public Transform Transform => transform;

        [Inject]
        public void Construct(PlayerConfig config) => Speed = config.Speed; 
    }
}