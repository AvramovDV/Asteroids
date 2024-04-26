using UnityEngine;

namespace Avramov.Asteroids
{
    public class ShipModel : SpaceObject
    {
        private SpaceShipSettings _settigns;
        public bool IsMoving { get; private set; } = false;

        public ShipModel(SpaceShipSettings spaceShipSettings, SpaceModel space) : base(space)
        {
            _settigns = spaceShipSettings;
        }

        public void Simulate()
        {
            SetupVelocity();
        }

        public void MoveShip(bool value) => IsMoving = value;

        public void RotateShip(float value)
        {
            float target = Angle + value * _settigns.RotationSpeed * Time.deltaTime;
            Angle = target;
        }

        private void SetupVelocity()
        {
            float acceleration = IsMoving ? _settigns.Acceleration : _settigns.Deceleration;
            Vector2 target = IsMoving ? Vector2.up.Rotate(Angle) * _settigns.MaxSpeed : Vector2.zero;
            target = Vector2.MoveTowards(Velocity, target, acceleration * Time.deltaTime);
            Velocity = target;
        }
    }
}

