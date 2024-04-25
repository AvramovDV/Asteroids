using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class BaseStateMachine
    {
        private Dictionary<Type, BaseState> _states = new Dictionary<Type, BaseState>();

        private BaseState _currentState;

        public void AddState(BaseState state)
        {
            if (_states.ContainsKey(state.GetType()))
                return;

            state.SwitchStateEvent += SwitchToState;
            _states.Add(state.GetType(), state);
        }

        public void Update()
        {
            _currentState?.UpdateState();
        }

        public void SwitchToState<T>() where T : BaseState => SwitchToState(typeof(T));

        public void SwitchToState(Type state)
        {
            _currentState?.EndState();
            _currentState = _states[state];
            _currentState?.StartState();
        }
    }
}

