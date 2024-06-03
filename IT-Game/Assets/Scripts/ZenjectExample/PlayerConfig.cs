using UnityEngine;

namespace ScriptsZenject
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 51)]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
    }
}