using UnityEngine;
using UnityEngine.Events;

namespace ScriptsZenject
{
    public class MobileInput : IInput
    {
        public event UnityAction<Vector3> ClickDown;
        public event UnityAction<Vector3> ClickUp;
        public event UnityAction<Vector3> Drag;
    }
}