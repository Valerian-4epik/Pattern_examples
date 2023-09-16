using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    public class GemsPanelAdapter : MonoBehaviour
    {
        [SerializeField] private CurrencyPanel _view;

        private GemStorage _storage;

        [Inject]
        public void Construct(GemStorage storage)
        {
            _storage = storage;
        }

        private void OnEnable()
        {
            _storage.OnGemChanged += OnMoneyChanged;
            _view.SetupMoney(_storage.Gem.ToString());
        }

        private void OnDisable()
        {
            _storage.OnGemChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            _view.UpdateMoney(money.ToString());
        }
    }
}