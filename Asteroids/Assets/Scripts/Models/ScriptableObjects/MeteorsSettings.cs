using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "MeteorsSettings", menuName = "Asteroids/MeteorsSettings")]
    public class MeteorsSettings : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public int Count { get; private set; }
        [field: SerializeField] public int Points { get; private set; }
    }
}

