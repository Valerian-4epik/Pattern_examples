using System;
using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public sealed class KeyboardInput : MonoBehaviour,
        Listeners.IStartGameListener,
        Listeners.IFinishGameListener
    {
        private bool isActive;
        
        public event Action<Vector3> OnMove;

        private void Update()
        {
            if (this.isActive)
            {
                this.HandleKeyboard();
            }
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.Move(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                this.Move(Vector3.back);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.Move(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.Move(Vector3.right);
            }
        }

        private void Move(Vector3 direction)
        {
            this.OnMove?.Invoke(direction);
        }

        public void OnStartGame()
        {
            this.isActive = true;
        }

        public void OnFinishGame()
        {
            this.isActive = false;
        }
    }
}