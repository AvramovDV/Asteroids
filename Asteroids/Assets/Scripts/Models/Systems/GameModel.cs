using System;
using System.Collections.Generic;

namespace Avramov.Asteroids
{
    public class GameModel
    {
        public event Action GameEndEvent;
        public SpaceObjects SpaceObjects {  get; private set; }
        public ShipModel Ship { get; private set; }
        public LaserEnergy LaserEnergy { get; private set; }
        public int Points { get; private set; }

        private GameSettings _settings;
        private EnemySpawner _enemySpawner;
        private List<IWeapon> _weapons = new List<IWeapon>();

        public GameModel(GameSettings settings)
        {
            _settings = settings;
            _enemySpawner = new EnemySpawner(this, _settings);
            SpaceObjects = new SpaceObjects(settings);
            LaserEnergy = new LaserEnergy(settings);
            SetupWeapons();
        }

        public void Start()
        {
            SpawnShip();
        }

        public void Simulate()
        {
            _enemySpawner.Update();
            SpaceObjects.MoveObjects();
            LaserEnergy.Update();
        }

        public void MoveShip(bool value) => Ship.MoveShip(value);

        public void RotateShip(float value) => Ship.RotateShip(value);

        public void ShootBulletWeapon() => _weapons[0].Shoot();
        public void ShootLaserWeapon() => _weapons[1].Shoot();

        public void AddPoints(int points) => Points += points;

        private void SetupWeapons()
        {
            _weapons.Add(new BulletWeapon(this, _settings));
            _weapons.Add(new LaserWeapon(this, _settings));
        }

        private void SpawnShip()
        {
            Ship = _settings.GetShipModel();
            Ship.CollideEvent += OnShipCollision;
            SpaceObjects.AddObject(Ship);
        }

        private void OnShipCollision(SpaceObject spaceObject) => GameEndEvent?.Invoke();
    }
}

