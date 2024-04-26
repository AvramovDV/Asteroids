using System;
using System.Collections.Generic;

namespace Avramov.Asteroids
{
    public class SpaceObjects
    {
        public event Action<SpaceObject> SpaceObjectAddedEvent;

        private GameSettings _gameSettings;

        private List<SpaceObject> _spaceObjects = new List<SpaceObject>();

        public SpaceObjects(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
        }

        public void AddObject(SpaceObject spaceObject)
        {
            _spaceObjects.Add(spaceObject);
            spaceObject.DestroyEvent += RemoveObject;
            SpaceObjectAddedEvent?.Invoke(spaceObject);
        }

        public void RemoveObject(SpaceObject spaceObject)
        {
            spaceObject.DestroyEvent -= RemoveObject;
            _spaceObjects.Remove(spaceObject);
        }

        public void MoveObjects()
        {
            for (int i = 0; i < _spaceObjects.Count; i++)
            {
                _spaceObjects[i].Move();
            }
        }

        public void Dispose()
        {
            for (int i = 0; i < _spaceObjects.Count; i++)
            {
                RemoveObject(_spaceObjects[i]);
            }

            _spaceObjects.Clear();
        }
    }
}

