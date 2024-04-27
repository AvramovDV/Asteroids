using UnityEngine;

namespace Avramov.Asteroids
{
    public class LaserPresenter
    {
        private GameModel _gameModel;
        private Assets _assets;

        public LaserPresenter(GameModel gameModel, Assets assets)
        {
            _gameModel = gameModel;
            _assets = assets;

            _gameModel.LaserEnergy.UseLaserEvent += ShowLaser;
        }

        private void ShowLaser()
        {
            Object.Instantiate(_assets.LaserEffect, _gameModel.Ship.Position, Quaternion.AngleAxis(_gameModel.Ship.Angle - 90f, Vector3.back));
        }
    }
}

