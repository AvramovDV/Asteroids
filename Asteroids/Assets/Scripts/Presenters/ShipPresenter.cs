using UnityEngine;

namespace Avramov.Asteroids
{
    public class ShipPresenter : SpaceObjectPresenter
    {
        public ShipPresenter(ShipModel shipModel, SpaceShipView shipView) : base(shipModel, shipView)
        {
        }
    }
}

