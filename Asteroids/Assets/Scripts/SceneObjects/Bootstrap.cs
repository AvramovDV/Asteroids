using UnityEngine;

namespace Avramov.Asteroids
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameSettings _gameSettings;
        [SerializeField] private Assets _assets;
        [SerializeField] private GameOverScreen _gameOverScreen;

        private AsteroidsControl _control;
        private GameModel _gameModel;
        private BaseStateMachine _gameState;

        private void Start()
        {
            Initialize();
        }

        private void Update()
        {
            _gameState.Update();
        }

        private void Initialize()
        {
            SetupInput();
            SetupModels();
            SetupGameStateMachine();
        }

        private void SetupInput()
        {
            _control = new AsteroidsControl();
            _control.Enable();
            _control.DefaultActionMap.Enable();
        }

        private void SetupModels()
        {
            _gameModel = new GameModel();
        }

        private void SetupGameStateMachine()
        {
            _gameState = new BaseStateMachine();

            _gameState.AddState(new BootstrapState(_gameModel, _gameSettings));
            _gameState.AddState(new GameLoopState(_gameModel, _control, _assets));
            _gameState.AddState(new GameEndState(_gameOverScreen, _gameModel));

            _gameState.SwitchToState<BootstrapState>();
        }
    }
}

