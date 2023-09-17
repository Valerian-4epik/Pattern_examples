using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts.HeroCharacteristics_practice
{
    public class UICharacteristicsInstaller : MonoContext.MonoContext
    {
        [SerializeField] private StatPanel _hitPointsView;
        [SerializeField] private StatPanel _damageView;
        [SerializeField] private StatPanel _speedView;
        
        private HitPointsPanelAdapter _hitPointsAdapter;

        [Inject]
        public void Construct(Character character)
        {
            _hitPointsAdapter = new HitPointsPanelAdapter(_hitPointsView, character);
        }

        protected override IEnumerable<object> ProvideComponents()
        {
            yield return _hitPointsAdapter;
        }
    }
}