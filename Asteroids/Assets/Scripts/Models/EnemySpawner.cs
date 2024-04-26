using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class EnemySpawner
    {
        private float _rate;
        private float _spawnTime;
        private Action[] _spawnActions;

        public EnemySpawner(float rate, params Action[] spawnActions)
        {
            _rate = rate;
            _spawnTime = Time.time;
            _spawnActions = spawnActions;
        }

        public void Update()
        {
            if(Time.time >= _spawnTime)
            {
                int random = UnityEngine.Random.Range(0, _spawnActions.Length);
                _spawnActions[random]?.Invoke();
                _spawnTime = Time.time + _rate;
            }
        }
    }
}

