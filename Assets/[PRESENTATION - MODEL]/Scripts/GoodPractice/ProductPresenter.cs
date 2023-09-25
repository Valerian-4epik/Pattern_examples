using System;
using _MODEL_VIEW_ADAPTER_.Scripts;
using UnityEngine;

namespace _PRESENTATION___MODEL_.Scripts.GoodPractice
{
    public sealed class ProductPresenter : IProductPresenter
    {
        private readonly Product _product;
        private readonly ProductBuyer _productBuyer;
        private readonly MoneyStorage _moneyStorage;
        
        public ProductPresenter(Product product, ProductBuyer productBuyer, MoneyStorage moneyStorage)
        {
            _product = product;
            _productBuyer = productBuyer;
            _moneyStorage = moneyStorage;
        }

        public string Title => _product.Title;

        public string Description => _product.Description;

        public Sprite ProductIcon => _product.Icon;

        public Sprite CurrencyIcon => _product.CurrencyIcon;

        public string Price => _product.Price.ToString();

        public bool IsButtonInteractable => _productBuyer.CanBuy(_product);

        public event Action OnBuyButtonStateChanged;

        public void Enable()
        {
            _moneyStorage.OnMoneyChanged += OnMoneyChanged;
        }
        
        public void Disable()
        {
            _moneyStorage.OnMoneyChanged -= OnMoneyChanged;
        }

        public void OnBuyButtonClicked()
        {
            if (_productBuyer.CanBuy(_product))
            {
                _productBuyer.Buy(_product);
            }
        }

        private void OnMoneyChanged(int _)
        {
            OnBuyButtonStateChanged?.Invoke();
        }
    }
}