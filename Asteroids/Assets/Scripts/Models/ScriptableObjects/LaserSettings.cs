using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "LaserSettings", menuName = "Asteroids/LaserSettings")]
    public class LaserSettings : ScriptableObject
    {
        [field: SerializeField] public int MaxChargesCount { get; private set; }
        [field: SerializeField] public float ChargingTime { get; private set; }
        [field: SerializeField] public LayerMask LaserLayerMask { get; private set; }
    }
}

