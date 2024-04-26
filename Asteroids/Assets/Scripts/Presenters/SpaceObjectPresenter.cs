using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObjectPresenter
    {
        private SpaceObject _spaceObject;
        private SpaceObjectView _view;

        public SpaceObjectPresenter(SpaceObject spaceObject, SpaceObjectView view)
        {
            _spaceObject = spaceObject;
            _view = Object.Instantiate(view, spaceObject.Position, Quaternion.identity);
            _view.CollideEvent += OnCollide;
        }

        public void Update()
        {
            _view.transform.position = _spaceObject.Position;
            _view.transform.rotation = Quaternion.AngleAxis(_spaceObject.Angle, Vector3.back);
        }

        private void OnCollide()
        {
            _spaceObject.Collide();
        }
    }
}

