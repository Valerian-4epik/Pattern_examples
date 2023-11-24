using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public sealed class MoveController : MonoBehaviour,
        Listeners.IStartGameListener,
        Listeners.IFinishGameListener
    {
        private IMoveInput _input;
        private IPlayer _player;
        
        public void Construct(IMoveInput input, IPlayer player)
        {
            _input = input;
            _player = player;
        }

        public void OnStartGame()
        {
            _input.OnMove += OnMove;
        }

        public void OnFinishGame()
        {
            _input.OnMove -= OnMove;
        }

        private void OnMove(Vector3 direction)
        {
            _player.Move(direction);
        }
    }
}