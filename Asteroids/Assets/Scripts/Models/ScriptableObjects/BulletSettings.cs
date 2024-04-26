using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "BulletSettings", menuName = "Asteroids/BulletSettings")]
    public class BulletSettings : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float LifeTime { get; private set; }
    }
}

