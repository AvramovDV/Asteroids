using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public abstract class SpaceObject
    {
        public event Action<SpaceObject> CollideEvent;
        public event Action<SpaceObject> DestroyEvent;
        public event Action UpdateEvent;

        public Vector2 Position { get; protected set; }
        public float Angle { get; protected set; }
        public Vector2 Velocity { get; protected set; }
        public Vector2 Direction => Vector2.up.Rotate(Angle);

        private SpaceData _space;

        public SpaceObject(SpaceData space, Vector2 position = default, float angle = 0f, float speed = 0f)
        {
            Position = position;
            Angle = angle;
            Velocity = Vector2.up.Rotate(Angle) * speed;
            _space = space;
        }

        public abstract SpaceObjectType SpaceObjectType { get; }

        public void Move()
        {
            Vector2 targetPosition = Velocity * Time.deltaTime + Position;
            targetPosition = _space.ApplyBorders(targetPosition);
            Position = targetPosition;
            UpdateEvent?.Invoke();
        }

        public void Collide() => CollideEvent?.Invoke(this);

        public void Destroy()
        {
            DestroyEvent?.Invoke(this);
        }
    }
}

