using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public sealed class MoveController : MonoBehaviour,
        Listeners.IStartGameListener,
        Listeners.IFinishGameListener
    {
        
        [SerializeField]
        private KeyboardInput input;

        [SerializeField]
        private Player player;

        public void OnStartGame()
        {
            this.input.OnMove += this.OnMove;
        }

        public void OnFinishGame()
        {
            this.input.OnMove -= this.OnMove;
        }

        private void OnMove(Vector3 direction)
        {
            this.player.Move(direction);
        }
    }
}