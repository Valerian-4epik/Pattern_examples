namespace _MODEL_VIEW_ADAPTER_.Scripts.MonoContext
{
    public class MoneyPanelAdapterMonoContext : IEnableComponent, IDisableComponent
    {
        private readonly CurrencyPanel _view;
        private readonly MoneyStorage _storage;

        public MoneyPanelAdapterMonoContext(CurrencyPanel view, MoneyStorage storage)
        {
            _view = view;
            _storage = storage;
        }

        public void OnEnable()
        {
            _storage.OnMoneyChanged += OnMoneyChanged;
            _view.SetupMoney(_storage.Money.ToString());
        }

        public void OnDisable()
        {
            _storage.OnMoneyChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            _view.UpdateMoney(money.ToString());
        }
    }
}