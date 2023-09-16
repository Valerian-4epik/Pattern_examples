using System;
using Sirenix.OdinInspector;

namespace _MODEL_VIEW_ADAPTER_.Scripts
{
    [Serializable]
    public sealed class MoneyStorage
    {
        public event Action<int> OnMoneyChanged;

        public int Money => _money;

        [ReadOnly] [ShowInInspector] private int _money;

        [Button]
        public void SetupMoney(int money)
        {
            _money = money;
        }

        [Button]
        public void AddMoney(int money)
        {
            _money += money;
            OnMoneyChanged?.Invoke(_money);
        }

        [Button]
        public void SpendMoney(int money)
        {
            _money -= money;
            OnMoneyChanged?.Invoke(_money);
        }
    }
}