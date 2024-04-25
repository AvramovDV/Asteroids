using UnityEngine;

namespace Avramov.Asteroids
{
    public class ShipModel : SpaceObject
    {
        private SpaceShipSettings _settigns;
        private bool _isMoving = false;

        public ShipModel(SpaceShipSettings spaceShipSettings)
        {
            _settigns = spaceShipSettings;
        }

        public void Simulate()
        {
            SetupVelocity();
        }

        public void MoveShip() => _isMoving = true;

        public void RotateShip(float value)
        {
            float target = Angle + value * _settigns.RotationSpeed * Time.deltaTime;
            SetupAngle(target);
        }

        private void SetupVelocity()
        {
            float acceleration = _isMoving ? _settigns.Acceleration : _settigns.Deceleration;
            Vector2 target = _isMoving ? Vector2.up.Rotate(Angle) * _settigns.MaxSpeed : Vector2.zero;
            target = Vector2.MoveTowards(Velocity, target, acceleration * Time.deltaTime);
            SetupVelocity(target);
            _isMoving = false;
        }
    }
}

