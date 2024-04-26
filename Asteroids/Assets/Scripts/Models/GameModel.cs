using System;

namespace Avramov.Asteroids
{
    public class GameModel : IDisposable
    {
        public event Action GameEndEvent;
        public SpaceObjects SpaceObjects {  get; private set; }
        public ShipModel Ship { get; private set; }
        public int Points { get; private set; }

        private GameSettings _settings;
        private EnemySpawner _enemySpawner;

        public void Initialize(GameSettings settings)
        {
            _settings = settings;
            _enemySpawner = new EnemySpawner(settings.AsteroidsSpawnRate, SpawnAlien, SpawnAsteroid);
            SpaceObjects = new SpaceObjects(settings);
        }

        public void Start()
        {
            SpawnShip();
            Ship.CollideEvent += OnShipCollision;
        }

        public void Simulate()
        {
            SpaceObjects.MoveObjects();
            _enemySpawner.Update();
        }

        public void MoveShip(bool value) => Ship.MoveShip(value);

        public void RotateShip(float value) => Ship.RotateShip(value);

        public void ShootBullets()
        {
            SpawnBullet();
        }

        public void Dispose()
        {
            SpaceObjects.Dispose();
            Points = 0;
        }

        private void SpawnShip()
        {
            Ship = _settings.GetShipModel();
            SpaceObjects.AddObject(Ship);
        }

        private void SpawnAsteroid()
        {
            AsteroidModel asteroid = _settings.GetAsteroidModel();
            asteroid.DestroyEvent += SpawnMeteors;
            asteroid.DestroyEvent += OnAsteroidDestroyed;
            SpaceObjects.AddObject(asteroid);
        }

        private void SpawnMeteors(SpaceObject spaceObject)
        {
            for (int i = 0; i < _settings.MeteorsSettings.Count; i++)
            {
                MeteorModel meteor = _settings.GetMeteorModel(spaceObject.Position);
                meteor.DestroyEvent += OnMeteorDestroyed;
                SpaceObjects.AddObject(meteor);
            }
        }

        private void SpawnAlien()
        {
            AlienModel alien = _settings.GetAlien(Ship);
            alien.DestroyEvent += OnAlienDestroyd;
            SpaceObjects.AddObject(alien);
        }

        private void SpawnBullet()
        {
            BulletModel bullet = _settings.GetBulletModel(Ship);
            SpaceObjects.AddObject(bullet);
        }

        private void OnShipCollision() => GameEndEvent?.Invoke();

        private void OnAsteroidDestroyed(SpaceObject asteroid)
        {
            Points += _settings.AsteroidSettings.Points;
        }

        private void OnMeteorDestroyed(SpaceObject spaceObject)
        {
            Points += _settings.MeteorsSettings.Points;
        }

        private void OnAlienDestroyd(SpaceObject spaceObject)
        {
            Points += _settings.AlienSettings.Points;
        }
    }
}

