using System;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class EnemySpawner
    {
        private GameModel _gameModel;
        private GameSettings _gameSettings;

        private float _spawnTime;
        private List<Action> _spawnActions = new List<Action>();

        public EnemySpawner(GameModel gameModel, GameSettings gameSettings)
        {
            _gameModel = gameModel;
            _gameSettings = gameSettings;
            _spawnTime = Time.time;
            _spawnActions.Add(SpawnAsteroid);
            _spawnActions.Add(SpawnAlien);
        }

        public void Update()
        {
            if(Time.time >= _spawnTime)
            {
                int random = UnityEngine.Random.Range(0, _spawnActions.Count);
                _spawnActions[random]?.Invoke();
                _spawnTime = Time.time + _gameSettings.AsteroidsSpawnRate;
            }
        }

        private void SpawnAsteroid()
        {
            AsteroidModel asteroid = _gameSettings.GetAsteroidModel();
            asteroid.DestroyEvent += OnAsteroidDestroyed;
            asteroid.CollideEvent += OnAsteroidCollided;
            _gameModel.SpaceObjects.AddObject(asteroid);
        }

        private void SpawnMeteors(SpaceObject spaceObject)
        {
            for (int i = 0; i < _gameSettings.MeteorsSettings.Count; i++)
            {
                MeteorModel meteor = _gameSettings.GetMeteorModel(spaceObject.Position);
                meteor.DestroyEvent += OnMeteorDestroyed;
                _gameModel.SpaceObjects.AddObject(meteor);
            }
        }

        private void SpawnAlien()
        {
            AlienModel alien = _gameSettings.GetAlien(_gameModel.Ship);
            alien.DestroyEvent += OnAlienDestroyed;
            _gameModel.SpaceObjects.AddObject(alien);
        }

        private void OnAsteroidDestroyed(SpaceObject spaceObject)
        {
            _gameModel.AddPoints(_gameSettings.AsteroidSettings.Points);
            spaceObject.DestroyEvent -= OnAsteroidDestroyed;
            spaceObject.CollideEvent -= OnAsteroidCollided;
        }

        private void OnAsteroidCollided(SpaceObject spaceObject)
        {
            SpawnMeteors(spaceObject);
        }

        private void OnMeteorDestroyed(SpaceObject spaceObject)
        {
            _gameModel.AddPoints(_gameSettings.MeteorsSettings.Points);
            spaceObject.DestroyEvent -= OnMeteorDestroyed;
        }

        private void OnAlienDestroyed(SpaceObject spaceObject)
        {
            _gameModel.AddPoints(_gameSettings.AlienSettings.Points);
            spaceObject.DestroyEvent -= OnAlienDestroyed;
        }
    }
}

