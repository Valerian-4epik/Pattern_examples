using _MODEL_VIEW_ADAPTER_.Scripts;
using _PRESENTATION___MODEL_.Scripts.UI;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _PRESENTATION___MODEL_.Scripts.GoodPractice
{
    public class ProductPopup : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;

        [SerializeField] private Image _image;

        [SerializeField] private BuyButton _buyButton;

        [Inject] private ProductBuyer _productBuyer;

        [Inject] private MoneyStorage _moneyStorage;

        private Product _product;

        [Button]
        public void Show(Product product) //Product
        {
            _product = product;
            gameObject.SetActive(true);

            _title.text = product.Title;
            _description.text = product.Description;
            _image.sprite = product.Icon;

            _buyButton.SetPrice(product.Price.ToString());
            _buyButton.AddListener(OnBuyButtonClicked);
            
            UpdateButtonState();
            _moneyStorage.OnMoneyChanged += OnMoneyChanged;
        }

        [Button]
        public void Hide()
        {
            gameObject.SetActive(false);
            _buyButton.RemoveListener(OnBuyButtonClicked);
            _moneyStorage.OnMoneyChanged -= OnMoneyChanged;

        }

        private void OnMoneyChanged(int money)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            var interactible = _productBuyer.CanBuy(_product); //хватает денег или нет?
            var buttonState = interactible ? State.AVAILABLE : State.LOCKED;
            _buyButton.SetState(buttonState);
            
        }

        private void OnBuyButtonClicked()
        {
            if (_productBuyer.CanBuy(_product))
            {
                _productBuyer.Buy(_product);
            }
        }
    }
}