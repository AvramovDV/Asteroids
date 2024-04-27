using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceObjectView : MonoBehaviour
    {
        public event Action CollideEvent;
        public event Action DestroyEvent;

        public void Collide() => CollideEvent?.Invoke();
        public void Destroy() => DestroyEvent?.Invoke();
    }
}

