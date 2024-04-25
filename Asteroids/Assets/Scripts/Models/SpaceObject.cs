using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObject
    {
        public Vector2 Position { get; private set; }
        public float Angle { get; private set; }
        public float Size { get; private set; }
        public Vector2 Velocity { get; private set; }

        public void MoveTo(Vector2 position) => Position = position;

        public void SetupVelocity(Vector2 velocity) => Velocity = velocity;

        public void SetupAngle(float angle) => Angle = angle;
    }
}

