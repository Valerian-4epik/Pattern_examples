using System.Collections.Generic;
using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public enum GameState
    {
        OFF = 0,
        PLAY = 1,
        PAUSE = 2,
        FINISH = 3,
    }
    
    public sealed class GameMachine : MonoBehaviour
    {
       public GameState GameState
        {
            get { return this.gameState; }
        }

        private readonly List<object> listeners = new();

        private GameState gameState = GameState.OFF;
        
        [ContextMenu("Start Game")]
        public void StartGame()
        {
            if (this.gameState != GameState.OFF)
            {
                Debug.LogWarning($"You can start game only from {GameState.OFF} state!");
                return;
            }

            this.gameState = GameState.PLAY;

            foreach (var listener in this.listeners)
            {
                if (listener is Listeners.IStartGameListener startListener)
                {
                    startListener.OnStartGame();
                }
            }
        }

        [ContextMenu("Pause Game")]
        public void PauseGame()
        {
            if (this.gameState != GameState.PLAY)
            {
                Debug.LogWarning($"You can pause game only from {GameState.PLAY} state!");
                return;
            }

            this.gameState = GameState.PAUSE;

            foreach (var listener in this.listeners)
            {
                if (listener is Listeners.IPauseGameListener pauseListener)
                {
                    pauseListener.OnPauseGame();
                }
            }
        }

        [ContextMenu("Resume Game")]
        public void ResumeGame()
        {
            if (this.gameState != GameState.PAUSE)
            {
                Debug.LogWarning($"You can resume game only from {GameState.PAUSE} state!");
                return;
            }

            this.gameState = GameState.PLAY;

            foreach (var listener in this.listeners)
            {
                if (listener is Listeners.IResumeGameListener resumeListener)
                {
                    resumeListener.OnResumeGame();
                }
            }
        }

        [ContextMenu("Finish Game")]
        public void FinishGame()
        {
            if (this.gameState != GameState.PLAY)
            {
                Debug.LogWarning($"You can finish game only from {GameState.PLAY} state!");
                return;
            }

            this.gameState = GameState.FINISH;

            foreach (var listener in this.listeners)
            {
                if (listener is Listeners.IFinishGameListener finishListener)
                {
                    finishListener.OnFinishGame();
                }
            }
        }

        public void AddListener(object listener)
        {
            this.listeners.Add(listener);
        }

        public void RemoveListener(object listener)
        {
            this.listeners.Remove(listener);
        }
    }
}