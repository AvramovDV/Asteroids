using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class AsteroidsModel
    {
        private SpaceModel _space;
        private GameSettings _gameSettings;

        public event Action<AsteroidModel> AsteroidCreatedEvent;
        public event Action<AsteroidModel> AsteroidDestroyedEvent;

        private List<AsteroidModel> _asteroids = new List<AsteroidModel>();

        private float _spawnTime;

        public AsteroidsModel(SpaceModel space, GameSettings gameSettings)
        {
            _space = space;
            _gameSettings = gameSettings;
        }

        public void Simulate()
        {
            if (Time.time >= _spawnTime)
            {
                CreateAsteroid();
                _spawnTime = Time.time + _gameSettings.AsteroidsSpawnRate;
            }
        }

        private void CreateAsteroid()
        {
            float x = UnityEngine.Random.Range(-_gameSettings.GameFieldWidth * 0.5f, _gameSettings.GameFieldWidth * 0.5f);
            Vector2 position = new Vector2(x, _gameSettings.GameFieldHeight * 0.5f);
            AsteroidModel asteroid = new AsteroidModel(position, _gameSettings.AsteroidSettings, _space);
            _asteroids.Add(asteroid);
            AsteroidCreatedEvent?.Invoke(asteroid);
        }

        private void DestroyAsteroid()
        {

        }
    }
}

