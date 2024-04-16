using UnityEngine;

namespace ScriptClass
{
    public class Car : MonoBehaviour
    {
        private string _name;
        private int _maximumSpeed;
        private CarColorType _colorType;

        public void Initialize(string name, int maximumSpeed, CarColorType colorType)
        {
            _name = name;
            _maximumSpeed = maximumSpeed;
            _colorType = colorType;
        }

        public void PrintStatusCar()
        {
            Debug.Log($"Name: {_name}, MaximumSpeed: {_maximumSpeed}, Color: {_colorType}");
        }
    }
}