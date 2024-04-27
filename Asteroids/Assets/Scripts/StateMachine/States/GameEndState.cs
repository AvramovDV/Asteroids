using UnityEngine.SceneManagement;

namespace Avramov.Asteroids
{
    public class GameEndState : BaseState
    {
        private GameOverScreen _gameOverScreen;
        private GameModel _gameModel;

        public GameEndState(GameOverScreen gameOverScreen, GameModel gameModel)
        {
            _gameOverScreen = gameOverScreen;
            _gameModel = gameModel;
        }

        public override void StartState()
        {
            _gameOverScreen.CountText.text = $"{_gameModel.Points}";
            _gameOverScreen.RestartButton.onClick.AddListener(Restart);
            _gameOverScreen.gameObject.SetActive(true);
        }

        public override void UpdateState() { }

        public override void EndState() { }

        private void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

