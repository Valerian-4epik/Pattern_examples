using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts.ServiceLocators
{
    public sealed class GameLocatorInstaller : MonoBehaviour
    {
        [SerializeField]
        private GameLocator _gameLocator;

        [SerializeField]
        private MonoBehaviour[] _gameServices;

        private void Awake()
        {
            foreach (var service in _gameServices)
            {
                _gameLocator.AddService(service);
            }
        }
    }
}