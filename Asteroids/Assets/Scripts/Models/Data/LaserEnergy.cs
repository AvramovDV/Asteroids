using System;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class LaserEnergy
    {
        public event Action UseLaserEvent;
        public int Charges { get; private set; }
        public float ChargingTime { get; private set; }

        private GameSettings _settings;
        private Action _chargingAction;

        public LaserEnergy (GameSettings settings)
        {
            _settings = settings;
            Charges = _settings.LaserSettings.MaxChargesCount;
        }

        public void Update()
        {
            _chargingAction?.Invoke();
        }

        public bool TryGetCharge()
        {
            if(Charges == 0)
                return false;

            ChangeCharge(-1);
            UseLaserEvent?.Invoke();
            return true;
        }

        private void ChangeCharge(int amount)
        {
            Charges += amount;
            ChargingTime = Charges < _settings.LaserSettings.MaxChargesCount ? _settings.LaserSettings.ChargingTime : 0f;
            _chargingAction = Charges < _settings.LaserSettings.MaxChargesCount ? Charging : null;
        }

        private void Charging()
        {
            ChargingTime -= Time.deltaTime;

            if (ChargingTime <= 0f)
            {
                ChangeCharge(1);
            }
        }
    }
}

