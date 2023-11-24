using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts.Refactoring
{
    public sealed class GameContextInstaller : MonoBehaviour
    {
        [SerializeField] private GameContext gameContext;
        [SerializeField] private MonoBehaviour[] installers;
        
        // private void Awake()
        // {
        //     foreach (var installer in this.installers)
        //     {
        //         if (installer is IGameServiceProvider serviceProvider)
        //         {
        //             this.gameContext.AddServices(serviceProvider.GetServices());
        //         }
        //
        //         if (installer is IGameListenerProvider listenerProvider)
        //         {
        //             this.gameContext.AddListeners(listenerProvider.GetListeners());
        //         }
        //     }
        // }
        //
        // private void Start()
        // {
        //     foreach (var installer in this.installers)
        //     {
        //         if (installer is IGameConstructor constructor)
        //         {
        //             constructor.ConstructGame(this.gameContext);
        //         }
        //     }
        // }
    }
}