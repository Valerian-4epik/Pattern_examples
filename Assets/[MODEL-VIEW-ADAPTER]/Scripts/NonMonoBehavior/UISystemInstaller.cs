using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts.NonMonoBehavior
{
    public sealed class UISystemInstaller : MonoBehaviour
    {
        [SerializeField] private CurrencyPanel _moneyView;
        [SerializeField] private CurrencyPanel _gemsView;

        private MoneyPanelAdapterNonMono _moneyAdapter;
        private GemsPanelAdapterNonMono _gemsAdapter;

        [Inject]
        public void Construct(MoneyStorage moneyStorage, GemStorage gemStorage)
        {
            _moneyAdapter = new MoneyPanelAdapterNonMono(_moneyView, moneyStorage);
            _gemsAdapter = new GemsPanelAdapterNonMono(_gemsView, gemStorage);
        }

        private void OnEnable()
        {
            _moneyAdapter.Enable();
            _gemsAdapter.Enable();
        }

        private void OnDisable()
        {
            _moneyAdapter.Disable();
            _gemsAdapter.Disable();
        }
    }
}