using _DI_OTUS_GULKIN_.Scripts.Refactoring;
using _DI_OTUS_GULKIN_.Scripts.ServiceLocators;
using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public sealed class GameContext : MonoBehaviour, IGameLocator, IGameMachine
    {
        public GameState GameState
        {
            get { return this._gameMachine.GameState; }
        }

        private readonly GameMachine _gameMachine = new();
        private readonly GameLocator _serviceLocator = new();
        
        public GameContext()
        {
            this._serviceLocator.AddService(this._gameMachine);
        }

        [ContextMenu("Start Game")]
        public void StartGame()
        {
            this._gameMachine.StartGame();
        }

        [ContextMenu("Pause Game")]
        public void PauseGame()
        {
            this._gameMachine.PauseGame();
        }

        [ContextMenu("Resume Game")]
        public void ResumeGame()
        {
            this._gameMachine.ResumeGame();
        }

        [ContextMenu("Finish Game")]
        public void FinishGame()
        {
            this._gameMachine.FinishGame();
        }

        public void AddListener(object listener)
        {
            this._gameMachine.AddListener(listener);
        }

        public void RemoveListener(object listener)
        {
            this._gameMachine.RemoveListener(listener);
        }
        
        public void AddService(object service)
        {
            this._serviceLocator.AddService(service);
        }

        public void RemoveService(object service)
        {
            this._serviceLocator.RemoveService(service);
        }

        public T GetService<T>()
        {
            return this._serviceLocator.GetService<T>();
        }
    }
}