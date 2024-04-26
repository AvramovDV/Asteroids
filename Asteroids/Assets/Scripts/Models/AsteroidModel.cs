using UnityEngine;

namespace Avramov.Asteroids
{
    public class AsteroidModel : SpaceObject
    {
        public AsteroidModel(Vector2 position, AsteroidSettings settings, SpaceModel space) : base(space)
        {
            Position = position;
            Angle = Random.Range(0f, 360f);
            Velocity = Vector2.up.Rotate(Angle) * settings.Speed;
        }
    }
}

