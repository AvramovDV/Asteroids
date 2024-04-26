using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "AlienSettings", menuName = "Asteroids/AlienSettings")]
    public class AlienSettings : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public int Points { get; private set; }
    }
}

