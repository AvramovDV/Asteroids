using UnityEngine;

namespace Avramov.Asteroids
{
    public class LaserWeapon : IWeapon
    {
        private GameModel _gameModel;
        private GameSettings _gameSettings;

        public LaserWeapon(GameModel gameModel, GameSettings gameSettings)
        {
            _gameModel = gameModel;
            _gameSettings = gameSettings;
        }

        public void Shoot()
        {
            if (!_gameModel.LaserEnergy.TryGetCharge())
                return;

            RaycastHit2D[] hits = Physics2D.RaycastAll(_gameModel.Ship.Position, _gameModel.Ship.Direction, _gameSettings.GameFieldWidth, _gameSettings.LaserSettings.LaserLayerMask);

            for (int i = 0; i < hits.Length; i++)
            {
                hits[i].transform.GetComponent<SpaceObjectView>().Destroy();
            }
        }
    }
}

