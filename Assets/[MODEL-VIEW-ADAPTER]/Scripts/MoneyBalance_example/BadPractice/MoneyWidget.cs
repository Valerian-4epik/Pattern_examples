using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    public sealed class MoneyWidget : MonoBehaviour
    {
        [SerializeField] private TMP_Text _currencyText;

        private MoneyStorage _moneyStorage;

        [Inject]
        public void Construct(MoneyStorage moneyStorage)
        {
            _moneyStorage = moneyStorage;
        }

        private void OnEnable()
        {
            _moneyStorage.OnMoneyChanged += OnMoneyChanged;
            UpdateText(_moneyStorage.Money);
        }

        private void OnDisable()
        {
            _moneyStorage.OnMoneyChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            UpdateText(money);
            AnimateTextBounce();
        }

        private void UpdateText(int money)
        {
            _currencyText.text = money.ToString();
        }

        private void AnimateTextBounce()
        {
            DOTween
                .Sequence()
                .Append(_currencyText.transform.DOScale(new Vector3(1.1f, 1.1f, 1.0f), 0.1f))
                .Append(_currencyText.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.3f));
        }
    }
}