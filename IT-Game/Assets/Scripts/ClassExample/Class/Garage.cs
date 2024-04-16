using UnityEngine;

namespace ScriptClass
{
    public class Garage : MonoBehaviour
    {
        [SerializeField] private Car _car;

        private void Start()
        {
            _car.Initialize("Ferrari", 350, CarColorType.Black);
            _car.PrintStatusCar();
        }
    }
}