using System;
using _MODEL_VIEW_ADAPTER_.Scripts;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace _PRESENTATION___MODEL_.Scripts
{
    [Serializable]
    public sealed class ProductBuyer
    {
        private readonly MoneyStorage _moneyStorage;

        public ProductBuyer(MoneyStorage moneyStorage)
        {
            _moneyStorage = moneyStorage;
        }

        [Button]
        public void Buy(Product product)
        {
            if (CanBuy(product))
            {
                _moneyStorage.SpendMoney(product.Price);
                Debug.Log($"<color=green> Product {product.Title} successfully bought </color>");
            }
            else
            {
                Debug.LogWarning($"<color=red> Not enough money fo buy product {product.Title} </color>");
            }
        }

        [Button]
        public bool CanBuy(Product product)
        {
            return _moneyStorage.Money >= product.Price;
        }
    }
}