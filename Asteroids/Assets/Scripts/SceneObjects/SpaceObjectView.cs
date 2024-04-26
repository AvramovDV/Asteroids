using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObjectView : MonoBehaviour
    {
        public event Action CollideEvent;

        public void Collide() => CollideEvent?.Invoke();
    }
}

