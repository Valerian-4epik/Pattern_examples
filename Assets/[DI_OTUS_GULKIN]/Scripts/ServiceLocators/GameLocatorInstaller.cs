using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts.ServiceLocators
{
    public sealed class GameLocatorInstaller : MonoBehaviour
    {
        [SerializeField]
        private GameLocator gameLocator;

        [SerializeField]
        private MonoBehaviour[] gameServices;

        private void Awake()
        {
            foreach (var service in this.gameServices)
            {
                this.gameLocator.AddService(service);
            }
        }
    }
}