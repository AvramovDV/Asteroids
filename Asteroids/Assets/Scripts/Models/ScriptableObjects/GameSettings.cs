using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "GameSettings", menuName = "Asteroids/GameSettings")]
    public class GameSettings : ScriptableObject
    {
        [field: SerializeField] public float GameFieldHeight { get; private set; }
        [field: SerializeField] public float GameFieldWidth { get; private set; }
        [field: SerializeField] public float AsteroidsSpawnRate { get; private set; }

        [field: SerializeField] public SpaceShipSettings ShipSettings { get; private set; }

        [field: SerializeField] public AsteroidSettings AsteroidSettings { get; private set;}
    }
}

