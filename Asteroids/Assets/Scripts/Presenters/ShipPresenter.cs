using UnityEngine;

namespace Avramov.Asteroids
{
    public class ShipPresenter
    {
        private ShipModel _shipModel;
        private SpaceShipView _shipView;

        public ShipPresenter(ShipModel shipModel, SpaceShipView shipView)
        {
            _shipModel = shipModel;
            _shipView = shipView;
        }

        public void Update()
        {
            //Debug.Log($"{_shipModel.Position}");
            _shipView.transform.position = _shipModel.Position;
            _shipView.transform.rotation = Quaternion.AngleAxis(_shipModel.Angle, Vector3.back);
        }
    }
}

