namespace Avramov.Asteroids
{
    public class BootstrapState : BaseState
    {
        private GameModel _gameModel;
        private GameSettings _gameSettings;

        public BootstrapState(GameModel gameModel, GameSettings gameSettings)
        {
            _gameModel = gameModel;
            _gameSettings = gameSettings;
        }

        public override void StartState()
        {
            _gameModel.Initialize(_gameSettings);
            SwitchState<GameLoopState>();
        }

        public override void UpdateState() { }

        public override void EndState()
        {

        }
    }
}

