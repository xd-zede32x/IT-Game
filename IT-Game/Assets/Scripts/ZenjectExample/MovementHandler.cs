using UnityEngine;

namespace ScriptsZenject
{
    public class MovementHandler : IDisposable
    {
        private IInput _input;

        public MovementHandler(IInput input)
        {
            _input = input;

            Debug.Log(input.GetType());

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

        private void OnClickDown(Vector3 arg0)
        {
          
        }

        private void OnClickUp(Vector3 arg0)
        {
    
        }

        private void OnDrag(Vector3 arg0)
        {
    
        }
    }
}