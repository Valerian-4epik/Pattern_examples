using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public class GameObservableInstaller : MonoBehaviour
    {
        [SerializeField]
        private GameMachine _gameMachine;
            
        [SerializeField]
        private MonoBehaviour[] gameListeners;

        private void Awake()
        {
            foreach (var listener in this.gameListeners)
            {
                this._gameMachine.AddListener(listener);
            }
        }
    }
}