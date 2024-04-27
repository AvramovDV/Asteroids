using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class BulletModel : SpaceObject
    {
        public event Action DieEvent;
        public override SpaceObjectType SpaceObjectType => SpaceObjectType.Bullet;

        private float _deathTime;

        public BulletModel(SpaceData space, float lifeTime, Vector2 position = default, float angle = 0, float speed = 0) : base(space, position, angle, speed)
        {
            _deathTime = Time.time + lifeTime;
            UpdateEvent += Simulate;
            CollideEvent += OnCollide;
        }

        private void Simulate()
        {
            if(Time.time >= _deathTime)
            {
                DieEvent?.Invoke();
                Destroy();
            }
        }

        private void OnCollide(SpaceObject spaceObject) => Destroy();
    }
}

