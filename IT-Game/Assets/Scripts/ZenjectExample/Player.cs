using Zenject;
using UnityEngine;

namespace ScriptsZenject
{
    public class Player : MonoBehaviour
    {
        private MovementHandler _movementHandler;

        [Inject]
        private void Construct(MovementHandler movementHandler)
        {
            Debug.Log(movementHandler.GetType());
            _movementHandler = movementHandler;
        }
    }
}