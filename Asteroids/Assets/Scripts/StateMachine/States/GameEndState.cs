using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            _gameOverScreen.CountText.text = $"{456}";
            _gameOverScreen.RestartButton.onClick.AddListener(Restart);
            _gameOverScreen.gameObject.SetActive(true);
        }

        public override void UpdateState() { }

        public override void EndState()
        {
            _gameOverScreen.RestartButton.onClick.RemoveListener(Restart);
            _gameOverScreen.gameObject.SetActive(false);
        }

        private void Restart()
        {

        }
    }
}

