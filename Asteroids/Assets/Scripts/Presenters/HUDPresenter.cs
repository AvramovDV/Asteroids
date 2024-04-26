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
            _hud.gameObject?.SetActive(true);
        }

        public void Update()
        {
            _hud.ScoreText.text = _gameModel.Points.ToString();
            _hud.CoordinatesText.text = $"{_gameModel.Ship.Position}";
            _hud.AngleText.text = _gameModel.Ship.Angle.ToString();
            _hud.SpeedText.text = _gameModel.Ship.Velocity.ToString();
            _hud.LaserStrikesText.text = $"not yet";
            _hud.LaserReloadingText.text = $"not yet";
        }

        public void Dispose()
        {
            _hud.gameObject?.SetActive(false);
        }
    }
}

