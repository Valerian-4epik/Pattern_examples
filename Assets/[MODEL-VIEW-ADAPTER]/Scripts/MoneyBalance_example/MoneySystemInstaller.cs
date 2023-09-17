using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    public sealed class MoneySystemInstaller : MonoInstaller
    {
        [SerializeField] private MoneyStorage _moneyStorage;

        public override void InstallBindings()
        {
            Container.Bind<MoneyStorage>().FromInstance(_moneyStorage);
        }
    }
}