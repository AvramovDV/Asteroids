using UnityEngine;

namespace Avramov.Asteroids
{
    public class AlienModel : SpaceObject
    {
        private SpaceObject _target;
        private float _speed;

        public override SpaceObjectType SpaceObjectType => SpaceObjectType.Alien;

        public AlienModel(SpaceData space, SpaceObject target, Vector2 position = default, float angle = 0, float speed = 0) : base(space, position, angle, speed)
        {
            _target = target;
            _speed = speed;
            UpdateEvent += MoveToTarget;
            CollideEvent += OnCollide;
        }

        private void MoveToTarget()
        {
            Vector2 direction = (_target.Position - Position).normalized;
            Velocity = direction * _speed;
        }

        private void OnCollide(SpaceObject spaceObject)
        {
            Destroy();
        }
    }
}

