using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _PRESENTATION___MODEL_.Scripts.UI
{
    public sealed class BuyButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [Space, SerializeField] private Image _buttonBackground;
        [SerializeField] private Sprite _availableButtonSprite;
        [SerializeField] private Sprite _lockedButtonSprite;
        [Space, SerializeField] private TMP_Text _priceText;
        [SerializeField] private Image _priceIcon;
        [Space, SerializeField] private State _state;

        public void AddListener(UnityAction action)
        {
            _button.onClick.AddListener(action);
        }

        public void RemoveListener(UnityAction action)
        {
            _button.onClick.RemoveListener(action);
        }

        public void SetPrice(string price)
        {
            _priceText.text = price;
        }

        public void SetIcon(Sprite icon)
        {
            _priceIcon.sprite = icon;
        }

        public void SetAvailable(bool isAvailable)
        {
            var state = isAvailable ? State.AVAILABLE : State.LOCKED;
            SetState(state);
        }

        public void SetState(State state)
        {
            _state = state;
            
            switch (state)
            {
                case State.AVAILABLE:
                    _button.interactable = true;
                    _buttonBackground.sprite = _availableButtonSprite;
                    break;
                
                case State.LOCKED:
                    _button.interactable = false;
                    _buttonBackground.sprite = _lockedButtonSprite;
                    break;
                
                default:
                    throw new Exception($"Undefined button state {state}");
            }
        }
    }
}