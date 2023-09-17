namespace _MODEL_VIEW_ADAPTER_.Scripts.NonMonoBehavior
{
    public sealed class MoneyPanelAdapterNonMono
    {
        private readonly CurrencyPanel _view;
        private readonly MoneyStorage _storage;

        public MoneyPanelAdapterNonMono(CurrencyPanel view, MoneyStorage storage)
        {
            _view = view;
            _storage = storage;
        }

        public void Enable()
        {
            _storage.OnMoneyChanged += OnMoneyChanged;
            _view.SetupMoney(_storage.Money.ToString());
        }

        public void Disable()
        {
            _storage.OnMoneyChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            _view.UpdateMoney(money.ToString());
        }
    }
}