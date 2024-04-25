using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "SpaceShipSettings", menuName = "Asteroids/SpaceShipSettings")]
    public class SpaceShipSettings : ScriptableObject
    {
        [field: SerializeField] public float Acceleration { get; private set; }
        [field: SerializeField] public float Deceleration { get; private set; }
        [field: SerializeField] public float MaxSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
    }
}

