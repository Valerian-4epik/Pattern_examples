using System;
using UnityEngine;

namespace _PRESENTATION___MODEL_.Scripts.GoodPractice
{
    public interface IProductPresenter
    {
        event Action OnBuyButtonStateChanged;
        
        string Title { get; }
        string Description { get; }
        Sprite ProductIcon { get; }
        Sprite CurrencyIcon { get; }
        string Price { get; }
        bool IsButtonInteractable { get; }

        void Enable();
        void Disable();
        void OnBuyButtonClicked();
    }
}