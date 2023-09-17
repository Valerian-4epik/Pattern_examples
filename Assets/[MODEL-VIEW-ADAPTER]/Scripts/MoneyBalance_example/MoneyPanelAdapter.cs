using System;
using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    public class MoneyPanelAdapter : MonoBehaviour
    {
        [SerializeField] private CurrencyPanel _view;

        private MoneyStorage _storage;

        [Inject]
        public void Construct(MoneyStorage storage)
        {
            _storage = storage;
        }

        private void OnEnable()
        {
            _storage.OnMoneyChanged += OnMoneyChanged;
            _view.SetupMoney(_storage.Money.ToString());
        }

        private void OnDisable()
        {
            _storage.OnMoneyChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            _view.UpdateMoney(money.ToString());
        }
    }
}