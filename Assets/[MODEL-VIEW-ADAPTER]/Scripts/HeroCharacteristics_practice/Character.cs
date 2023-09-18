using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _MODEL_VIEW_ADAPTER_.Scripts.HeroCharacteristics_practice
{
    public sealed class Character : MonoBehaviour
    {
        [SerializeField] private int _hitPoints;
        [SerializeField] private int _damage;
        [SerializeField] private float _speed;

        public event Action<float> OnHitPointsChanged;
        public event Action<float> OnDamageChanged;
        public event Action<float> OnSpeedChanged;

        public int GetHitPoints() => _hitPoints;

        public int GetDamage() => _damage;

        public float GetSpeed() => _speed;

        [Button]
        public void SetHitPoints(int hitPoints)
        {
            _hitPoints = hitPoints;
            OnHitPointsChanged?.Invoke(_hitPoints);
        }

        [Button]
        public void SetDamage(int damage)
        {
            _damage = damage;
            OnDamageChanged?.Invoke(_damage);
        }
            
        [Button]
        public void SetSpeed(float speed)
        {
            _speed = speed;
            OnSpeedChanged?.Invoke(_speed);
        }
    }
}