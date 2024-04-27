using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObjectPresenter
    {
        public event Action<SpaceObjectPresenter> DestroyedEvent;

        private SpaceObject _spaceObject;
        private SpaceObjectView _view;

        public SpaceObjectPresenter(SpaceObject spaceObject, SpaceObjectView view)
        {
            _spaceObject = spaceObject;
            _view = UnityEngine.Object.Instantiate(view, spaceObject.Position, Quaternion.identity);
            _view.CollideEvent += OnCollide;
            _view.DestroyEvent += OnDestroySpaceObject;
            _spaceObject.UpdateEvent += Update;
            _spaceObject.DestroyEvent += OnDestroy;
        }

        private void Update()
        {
            _view.transform.position = _spaceObject.Position;
            _view.transform.rotation = Quaternion.AngleAxis(_spaceObject.Angle, Vector3.back);
        }

        private void OnCollide()
        {
            _spaceObject.Collide();
        }

        private void OnDestroySpaceObject()
        {
            _spaceObject?.Destroy();
        }

        private void OnDestroy(SpaceObject spaceObject)
        {
            if (_view == null)
                return;

            _view.CollideEvent -= OnCollide;
            _view.DestroyEvent -= OnDestroySpaceObject;
            _spaceObject.UpdateEvent -= Update;
            _spaceObject.DestroyEvent -= OnDestroy;
            DestroyedEvent?.Invoke(this);
            UnityEngine.Object.Destroy(_view.gameObject);
        }
    }
}

