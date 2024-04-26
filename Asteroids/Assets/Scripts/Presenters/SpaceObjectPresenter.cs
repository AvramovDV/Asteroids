using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObjectPresenter : IDisposable
    {
        public event Action<SpaceObjectPresenter> DestroyedEvent;

        private SpaceObject _spaceObject;
        private SpaceObjectView _view;

        public SpaceObjectPresenter(SpaceObject spaceObject, SpaceObjectView view)
        {
            _spaceObject = spaceObject;
            _view = UnityEngine.Object.Instantiate(view, spaceObject.Position, Quaternion.identity);
            _view.CollideEvent += OnCollide;
            _spaceObject.UpdateEvent += Update;
            _spaceObject.DestroyEvent += OnDestroy;
        }

        public void Dispose()
        {
            OnDestroy(_spaceObject);
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

        private void OnDestroy(SpaceObject spaceObject)
        {
            if (_view == null)
                return;

            _view.CollideEvent -= OnCollide;
            _spaceObject.UpdateEvent -= Update;
            _spaceObject.DestroyEvent -= OnDestroy;
            DestroyedEvent?.Invoke(this);
            UnityEngine.Object.Destroy(_view.gameObject);
        }
    }
}

