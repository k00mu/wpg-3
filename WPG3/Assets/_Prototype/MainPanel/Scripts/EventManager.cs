using System;
using UnityEngine;

namespace MainPanel
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public event Action<bool, EnvironmentType> onEnvironmentRange;
        public void EnvironmentRange(bool _isOn, EnvironmentType _environmentType)
        {
            onEnvironmentRange?.Invoke(_isOn, _environmentType);
        }

        public event Action<EnvironmentType> onEnvironmentClick;
        public void EnvironmentClick(EnvironmentType _environmentType)
        {
            onEnvironmentClick?.Invoke(_environmentType);
        }

        public event Action<float> onBedBlanketChange;
        public void BedBlanketChange(float _value)
        {
            onBedBlanketChange?.Invoke(_value);
        }
    }
}
