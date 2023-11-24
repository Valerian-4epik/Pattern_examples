using System;
using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public sealed class KeyboardInput : MonoBehaviour,
        IMoveInput,
        Listeners.IStartGameListener,
        Listeners.IFinishGameListener
    {
        private bool _isActive;
        
        public event Action<Vector3> OnMove;

        private void Update()
        {
            if (_isActive)
            {
                HandleKeyboard();
            }
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Move(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Move(Vector3.back);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Move(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Move(Vector3.right);
            }
        }

        private void Move(Vector3 direction)
        {
            OnMove?.Invoke(direction);
        }

        public void OnStartGame()
        {
            _isActive = true;
        }

        public void OnFinishGame()
        {
            _isActive = false;
        }
    }
}