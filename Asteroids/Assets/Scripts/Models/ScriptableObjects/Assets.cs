using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "Assets", menuName = "Asteroids/Assets")]
    public class Assets : ScriptableObject
    {
        [field: SerializeField] public SpaceObjectView ShipView { get; private set; }
        [field: SerializeField] public SpaceObjectView AsteroidView { get; private set; }
        [field: SerializeField] public SpaceObjectView MeteorView { get; private set; }
        [field: SerializeField] public SpaceObjectView BulletView { get; private set; }
    }
}

