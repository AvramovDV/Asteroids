using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "AsteroidSettings", menuName = "Asteroids/AsteroidSettings")]
    public class AsteroidSettings : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
    }
}

