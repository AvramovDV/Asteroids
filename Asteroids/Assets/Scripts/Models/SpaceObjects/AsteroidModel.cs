using UnityEngine;

namespace Avramov.Asteroids
{
    public class AsteroidModel : SpaceObject
    {
        public override SpaceObjectType SpaceObjectType => SpaceObjectType.Asteroid;

        public AsteroidModel(SpaceData space, Vector2 position = default, float angle = 0, float speed = 0) : base(space, position, angle, speed)
        {
            CollideEvent += OnCollided;
        }

        private void OnCollided(SpaceObject spaceObject)
        {
            Destroy();
        }
    }
}

