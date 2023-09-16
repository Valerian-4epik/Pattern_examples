using UnityEngine;
using Zenject;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    public class GemSystemInstaller : MonoInstaller
    {
        [SerializeField] private GemStorage _gemStorage;

        public override void InstallBindings()
        {
            Container.Bind<GemStorage>().FromInstance(_gemStorage);
        }
    }
}