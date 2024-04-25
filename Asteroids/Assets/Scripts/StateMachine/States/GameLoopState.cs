namespace Avramov.Asteroids
{
    public class GameLoopState : BaseState
    {
        private GameModel _gameModel;
        private ShipPresenter _shipPresenter;
        private SpaceShipView _spaceShipView;
        private AsteroidsControl _asteroidsControl;

        public GameLoopState(GameModel gameModel, SpaceShipView shipView, AsteroidsControl asteroidsControl)
        {
            _gameModel = gameModel;
            _spaceShipView = shipView;
            _asteroidsControl = asteroidsControl;
        }

        public override void StartState()
        {
            _shipPresenter = new ShipPresenter(_gameModel.ShipModel, _spaceShipView);
        }

        public override void UpdateState()
        {
            ListenInput();
            _gameModel.Simulate();
            _shipPresenter.Update();
        }

        public override void EndState()
        {

        }

        private void ListenInput()
        {
            if(_asteroidsControl.DefaultActionMap.Acceleration.IsPressed()) _gameModel.MoveShip();
            _gameModel.RotateShip(_asteroidsControl.DefaultActionMap.Rotation.ReadValue<float>());
        }
    }
}

