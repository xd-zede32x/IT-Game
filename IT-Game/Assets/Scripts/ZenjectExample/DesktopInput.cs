﻿using UnityEngine;
using UnityEngine.Events;

namespace ScriptsZenject
{
    public class DesktopInput : IInput
    {
        public event UnityAction<Vector3> Drag;
        public event UnityAction<Vector3> ClickUp;
        public event UnityAction<Vector3> ClickDown;
    }
}