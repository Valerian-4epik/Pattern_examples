using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts.ServiceLocators
{
    public class GameAssembler : MonoBehaviour
    {
        [SerializeField]
        private GameLocator gameLocator;
    
        [Space]
        [SerializeField]
        private MoveController moveController;
    
        private void Start()
        {
            this.ConstructMoveController();
        }

        private void ConstructMoveController()
        {
            var keyboardInput = this.gameLocator.GetService<IMoveInput>();
            var player = this.gameLocator.GetService<IPlayer>();
            this.moveController.Construct(keyboardInput, player);
        }
    }
}