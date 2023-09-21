using UnityEngine;
using Zenject;

namespace _PRESENTATION___MODEL_.Scripts
{
    public class ProductSystemInstaller : MonoInstaller
    {
        [SerializeField] private ProductBuyer _productBuyer;

        public override void InstallBindings()
        {
            Container.Bind<ProductBuyer>()
                .AsSingle()
                .OnInstantiated<ProductBuyer>((_, it) => _productBuyer = it)
                .NonLazy();
        }
    }
}