using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class BulletModel : SpaceObject
    {
        public event Action DieEvent;

        private float _deathTime;

        public override SpaceObjectType SpaceObjectType => SpaceObjectType.Bullet;

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

        private void OnCollide() => Destroy();
    }
}

