using System.Collections.Generic;
using _MODEL_VIEW_ADAPTER_.Scripts.MonoContext;
using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts.MoneyBalance_example.MonoContext
{
    public class UISystemInstallerMonoContext : Scripts.MonoContext.MonoContext
    {
        [SerializeField] private CurrencyPanel _moneyView;
        [SerializeField] private CurrencyPanel _gemsView;

        private MoneyPanelAdapterMonoContext _moneyAdapter;
        private GemsPanelAdapterMonoContext _gemsAdapter;

        [Inject]
        public void Construct(MoneyStorage moneyStorage, GemStorage gemStorage)
        {
            _moneyAdapter = new MoneyPanelAdapterMonoContext(_moneyView, moneyStorage);
            _gemsAdapter = new GemsPanelAdapterMonoContext(_gemsView, gemStorage);
        }

        protected override IEnumerable<object> ProvideComponents()
        {
            yield return _moneyAdapter;
            yield return _gemsAdapter;
        }
    }
}