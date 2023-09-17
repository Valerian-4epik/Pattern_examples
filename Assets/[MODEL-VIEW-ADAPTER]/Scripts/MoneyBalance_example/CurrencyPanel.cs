using DG.Tweening;
using TMPro;
using UnityEngine;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    public sealed class CurrencyPanel : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _currencyText;

        public void SetupMoney(string money)
        {
            _currencyText.text = money;
        }

        public void UpdateMoney(string money)
        {
            _currencyText.text = money;
            AnimateText();
        }

        private void AnimateText()
        {
            DOTween
                .Sequence()
                .Append(_currencyText.transform.DOScale(new Vector3(1.2f, 1.2f, 1.0f), 0.1f))
                .Append(_currencyText.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.3f));
        }
    }
}
