namespace Avramov.Asteroids
{
    public class BulletWeapon : IWeapon
    {
        private GameModel _gameModel;
        private GameSettings _gameSettings;

        public BulletWeapon(GameModel gameModel, GameSettings gameSettings)
        {
            _gameModel = gameModel;
            _gameSettings = gameSettings;
        }

        public void Shoot()
        {
            BulletModel bullet = _gameSettings.GetBulletModel(_gameModel.Ship);
            _gameModel.SpaceObjects.AddObject(bullet);
        }
    }
}

