using System;
using _PRESENTATION___MODEL_.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _PRESENTATION___MODEL_.Scripts.GoodPractice
{
    public class ProductPopupGoodPractice : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;

        [SerializeField] private Image _image;

        [SerializeField] private BuyButton _buyButton;

        private IProductPresenter _presenter;

        public void Show(object args)
        {
            if (args is not IProductPresenter presenter)
            {
                throw new Exception("Expected product presenter");
            }
            
            _title.text = presenter.Title;
            _description.text = presenter.Description;
            _image.sprite = presenter.ProductIcon;
            
            _buyButton.SetPrice(_presenter.Price);
            _buyButton.SetIcon(_presenter.CurrencyIcon);
            _buyButton.AddListener(OnBuyButtonClicked);
            
            _presenter = presenter;
            _presenter.OnBuyButtonStateChanged += UpdateButtonState;
            UpdateButtonState();
        }

        public void Hide()
        {
            _presenter.OnBuyButtonStateChanged -= UpdateButtonState;
            _buyButton.RemoveListener(OnBuyButtonClicked);
        }

        private void OnBuyButtonClicked()
        {
            _presenter.OnBuyButtonClicked();
        }
        
        private void UpdateButtonState()
        {
            var interactible = _presenter.IsButtonInteractable;
            var buttonState = interactible ? State.AVAILABLE : State.LOCKED;
            _buyButton.SetState(buttonState);
            
        }
    }
}