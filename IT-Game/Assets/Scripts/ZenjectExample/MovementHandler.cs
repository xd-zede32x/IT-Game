using System;
using UnityEngine;

namespace ScriptsZenject
{
    public class MovementHandler : IDisposable
    {
        private IInput _input;
        private IMovable _movable;

        public MovementHandler(IInput input, IMovable movable)
        {
            _input = input;
            _movable = movable;

            Debug.Log(_input.GetType());
            Debug.Log(_movable.GetType());
            Debug.Log($"Скорость полученного IMovable: {_movable.Speed}");

            _input.ClickDown += OnClickDown;
            _input.ClickUp += OnClickUp;
            _input.Drag += OnDrag;
        }

        public void Dispose()
        {
            _input.ClickDown -= OnClickDown;
            _input.ClickUp -= OnClickUp;
            _input.Drag -= OnDrag;
        }

        private void OnClickDown(Vector3 arg0) => Debug.Log("ClickDown");

        private void OnClickUp(Vector3 arg0) => Debug.Log("ClickUp");

        private void OnDrag(Vector3 arg0) => Debug.Log("Drag");
    }
}