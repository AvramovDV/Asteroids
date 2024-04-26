namespace Avramov.Asteroids
{
    public class GameLoopState : BaseState
    {
        private GameModel _gameModel;
        private AsteroidsControl _asteroidsControl;
        private HUDPresenter _hudPresenter;
        private SpaceObjectsPresenter _spaceObjectsPresenter;

        private Assets _assets;
        private HUD _hud;

        public GameLoopState(GameModel gameModel, AsteroidsControl asteroidsControl, Assets assets, HUD hud)
        {
            _gameModel = gameModel;
            _asteroidsControl = asteroidsControl;
            _assets = assets;
            _hud = hud;
        }

        public override void StartState()
        {
            _hudPresenter = new HUDPresenter(_hud, _gameModel);
            _spaceObjectsPresenter = new SpaceObjectsPresenter(_gameModel, _assets);
            _spaceObjectsPresenter.Initialize();
            _gameModel.GameEndEvent += OnGameEnd;
            _gameModel.Start();
        }

        public override void UpdateState()
        {
            ListenInput();
            _gameModel?.Simulate();
            _hudPresenter.Update();
        }

        public override void EndState()
        {
            _gameModel.GameEndEvent -= OnGameEnd;
            _spaceObjectsPresenter.Dispose();
            _hudPresenter?.Dispose();
        }

        private void ListenInput()
        {
            _gameModel.MoveShip(_asteroidsControl.DefaultActionMap.Acceleration.IsPressed());
            _gameModel.RotateShip(_asteroidsControl.DefaultActionMap.Rotation.ReadValue<float>());
            if (_asteroidsControl.DefaultActionMap.FireBullet.WasPressedThisFrame()) _gameModel.ShootBullets();
        }

        private void OnGameEnd()
        {
            SwitchState<GameEndState>();
        }
    }
}

