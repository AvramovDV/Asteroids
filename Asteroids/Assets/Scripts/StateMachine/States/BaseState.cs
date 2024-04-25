using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
    public abstract class BaseState
    {
        public event Action<Type> SwitchStateEvent;

        public abstract void StartState();
        public abstract void UpdateState();
        public abstract void EndState();

        protected void SwitchState<T>() => SwitchStateEvent?.Invoke(typeof(T));
    }
}

