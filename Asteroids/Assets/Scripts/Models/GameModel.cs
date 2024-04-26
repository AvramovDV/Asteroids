using System;

namespace Avramov.Asteroids
{
    public class GameModel
    {
        public event Action GameEndEvent;

        private GameSettings _settings;

        private SpaceModel _spaceModel;

        public AsteroidsModel Asteroids { get; private set; }
        public ShipModel ShipModel {  get; private set; }

        public void Initialize(GameSettings settings)
        {
            _settings = settings;
            _spaceModel = new SpaceModel(_settings.GameFieldWidth, _settings.GameFieldHeight);
            Asteroids = new AsteroidsModel(_spaceModel, settings);
            ShipModel = new ShipModel(_settings.ShipSettings, _spaceModel);
            ShipModel.CollideEvent += OnShipCollision;
        }

        public void Simulate()
        {
            _spaceModel.MoveSpaceObjects();
            Asteroids.Simulate();
            ShipModel.Simulate();
        }

        public void MoveShip(bool value) => ShipModel.MoveShip(value);

        public void RotateShip(float value) => ShipModel.RotateShip(value);

        private void OnShipCollision() => GameEndEvent?.Invoke();
    }
}

