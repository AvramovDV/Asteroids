using System.Diagnostics;

namespace Avramov.Asteroids
{
    public class GameLoopState : BaseState
    {
        private GameModel _gameModel;
        private ShipPresenter _shipPresenter;
        private AsteroidsControl _asteroidsControl;
        private AsteroidsPresenter _asteroidsPresenter;

        private Assets _assets;

        public GameLoopState(GameModel gameModel, AsteroidsControl asteroidsControl, Assets assets)
        {
            _gameModel = gameModel;
            _asteroidsControl = asteroidsControl;
            _assets = assets;
        }

        public override void StartState()
        {
            _shipPresenter = new ShipPresenter(_gameModel.ShipModel, (SpaceShipView)_assets.ShipView);
            _asteroidsPresenter = new AsteroidsPresenter(_gameModel.Asteroids, _assets.AsteroidView);
            _gameModel.GameEndEvent += OnGameEnd;
        }

        public override void UpdateState()
        {
            ListenInput();
            _gameModel?.Simulate();
            _shipPresenter?.Update();
            _asteroidsPresenter?.Update();
        }

        public override void EndState()
        {
            _gameModel.GameEndEvent -= OnGameEnd;
        }

        private void ListenInput()
        {
            _gameModel.MoveShip(_asteroidsControl.DefaultActionMap.Acceleration.IsPressed());
            _gameModel.RotateShip(_asteroidsControl.DefaultActionMap.Rotation.ReadValue<float>());
        }

        private void OnGameEnd()
        {
            SwitchState<GameEndState>();
        }
    }
}

