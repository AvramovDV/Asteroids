using UnityEngine;

namespace Avramov.Asteroids
{
    public class MeteorModel : SpaceObject
    {
        public override SpaceObjectType SpaceObjectType => SpaceObjectType.Meteor;

        public MeteorModel(SpaceData space, Vector2 position = default, float angle = 0, float speed = 0) : base(space, position, angle, speed)
        {
            CollideEvent += OnCollide;
        }

        private void OnCollide(SpaceObject spaceObject) => Destroy();
    }
}

