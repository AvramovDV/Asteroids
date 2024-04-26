using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObject
    {
        public event Action CollideEvent;

        public Vector2 Position { get; protected set; }
        public float Angle { get; protected set; }
        public float Size { get; private set; }
        public Vector2 Velocity { get; protected set; }

        private SpaceModel _space;

        public SpaceObject(SpaceModel space)
        {
            _space = space;
            _space.AddObjectToSpace(this);
        }

        public void Move()
        {
            Vector2 targetPosition = Velocity * Time.deltaTime + Position;
            targetPosition = _space.ApplyBorders(targetPosition);
            Position = targetPosition;
        }

        public void Collide() => CollideEvent?.Invoke();
    }
}

