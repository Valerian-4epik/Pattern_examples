using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    [Serializable]
    public sealed class GemStorage
    {
        public event Action<int> OnGemChanged;

        public int Gem => _gem;

        [ReadOnly] [ShowInInspector] private int _gem;

        [Button]
        public void SetupGems(int gem)
        {
            _gem = gem;
        }

        [Button]
        public void AddGems(int gem)
        {
            _gem += gem;
            OnGemChanged?.Invoke(_gem);
        }

        [Button]
        public void SpendGems(int gem)
        {
            _gem -= gem;
            OnGemChanged?.Invoke(_gem);
        }
    }
}