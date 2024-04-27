namespace Avramov.Asteroids
{
    public class GameLoopState : BaseState
    {
        private GameModel _gameModel;
        private AsteroidsControl _asteroidsControl;
        private Assets _assets;
        private HUD _hud;

        private HUDPresenter _hudPresenter;
        private SpaceObjectsPresenter _spaceObjectsPresenter;
        private LaserPresenter _laserPresenter;

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
            _laserPresenter = new LaserPresenter(_gameModel, _assets);

            _hudPresenter.SetActive(true);
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
            _hudPresenter?.SetActive(false);
        }

        private void ListenInput()
        {
            _gameModel.MoveShip(_asteroidsControl.DefaultActionMap.Acceleration.IsPressed());
            _gameModel.RotateShip(_asteroidsControl.DefaultActionMap.Rotation.ReadValue<float>());
            if (_asteroidsControl.DefaultActionMap.FireBullet.WasPressedThisFrame()) _gameModel.ShootBulletWeapon();
            if (_asteroidsControl.DefaultActionMap.FireLaser.WasPressedThisFrame()) _gameModel.ShootLaserWeapon();
        }

        private void OnGameEnd()
        {
            SwitchState<GameEndState>();
        }
    }
}

