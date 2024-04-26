using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceShipView : SpaceObjectView
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            collision.GetComponent<SpaceObjectView>()?.Collide();
            Collide();
        }
    }
}

