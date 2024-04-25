namespace Avramov.Asteroids
{
    public class GameModel
    {
        private GameSettings _settings;

        private SpaceModel _spaceModel;
        public ShipModel ShipModel {  get; private set; }

        public void Initialize(GameSettings settings)
        {
            _settings = settings;
            _spaceModel = new SpaceModel(_settings.GameFieldWidth, _settings.GameFieldHeight);
            ShipModel = new ShipModel(_settings.ShipSettings);

            _spaceModel.AddObjectToSpace(ShipModel);
        }

        public void Simulate()
        {
            _spaceModel.MoveSpaceObjects();
            ShipModel.Simulate();
        }

        public void MoveShip() => ShipModel.MoveShip();

        public void RotateShip(float value) => ShipModel.RotateShip(value);
    }
}

