namespace Avramov.Asteroids
{
    public class HUDPresenter
    {
        private HUD _hud;
        private GameModel _gameModel;

        public HUDPresenter(HUD hud, GameModel gameModel)
        {
            _hud = hud;
            _gameModel = gameModel;
        }

        public void Update()
        {
            _hud.ScoreText.text = _gameModel.Points.ToString();
            _hud.CoordinatesText.text = $"{_gameModel.Ship.Position}";
            _hud.AngleText.text = _gameModel.Ship.Angle.ToString();
            _hud.SpeedText.text = _gameModel.Ship.Velocity.ToString();
            _hud.LaserStrikesText.text = _gameModel.LaserEnergy.Charges.ToString();
            _hud.LaserReloadingText.text = _gameModel.LaserEnergy.ChargingTime.ToString("F1");
        }

        public void SetActive(bool value)
        {
            _hud.gameObject?.SetActive(value);
        }
    }
}

