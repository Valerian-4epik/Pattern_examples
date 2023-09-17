using DG.Tweening;
using TMPro;
using UnityEngine;

namespace _MODEL_VIEW_ADAPTER_.Scripts.HeroCharacteristics_practice
{
    public class StatPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _viewText;

        public void SetupText(string view)
        {
            _viewText.text = view;
        }

        public void UpdateText(string view)
        {
            _viewText.text = view;
            AnimateText();
        }
        
        private void AnimateText()
        {
            DOTween
                .Sequence()
                .Append(_viewText.transform.DOScale(new Vector3(1.2f, 1.2f, 1.0f), 0.1f))
                .Append(_viewText.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.3f));
        }
    }
}
