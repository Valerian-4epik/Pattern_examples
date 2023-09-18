using _MODEL_VIEW_ADAPTER_.Scripts.MonoContext;
using UnityEngine;

namespace _MODEL_VIEW_ADAPTER_.Scripts.HeroCharacteristics_practice
{
    public class CharacterAdapter : MonoBehaviour
    {
        [SerializeField] private StatPanel _viewHitPoints;
        [SerializeField] private StatPanel _viewDamage;
        [SerializeField] private StatPanel _viewSpeed;
        [SerializeField] private Character _character;

        public void OnEnable()
        {
            _character.OnHitPointsChanged += OnHitPointsChanged;
            _character.OnDamageChanged += OnDamageChanged;
            _character.OnDamageChanged += OnSpeedChanged;
            _viewHitPoints.SetupText(_character.GetHitPoints().ToString());
            _viewDamage.SetupText(_character.GetDamage().ToString());
            _viewSpeed.SetupText(_character.GetSpeed().ToString());
        }

        public void OnDisable()
        {
            _character.OnHitPointsChanged -= OnHitPointsChanged;
            _character.OnDamageChanged -= OnDamageChanged;
            _character.OnDamageChanged -= OnSpeedChanged;
        }

        private void OnHitPointsChanged(float hitValue)
        {
            _viewHitPoints.UpdateText(hitValue.ToString());
        }

        private void OnDamageChanged(float damage)
        {
            _viewDamage.UpdateText(damage.ToString());
        }

        private void OnSpeedChanged(float speed)
        {
            _viewSpeed.SetupText(speed.ToString());
        }
    }
}