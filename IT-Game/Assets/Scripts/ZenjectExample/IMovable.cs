using UnityEngine;

namespace ScriptsZenject
{
    public interface IMovable
    {
        float Speed { get; }
        Transform Transform { get; }
    }
}