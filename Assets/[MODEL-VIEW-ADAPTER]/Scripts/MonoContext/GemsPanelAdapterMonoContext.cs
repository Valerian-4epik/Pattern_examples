namespace _MODEL_VIEW_ADAPTER_.Scripts.MonoContext
{
    public class GemsPanelAdapterMonoContext : IEnableComponent, IDisableComponent
    {
        private readonly CurrencyPanel _view;
        private readonly GemStorage _storage;

        public GemsPanelAdapterMonoContext(CurrencyPanel view, GemStorage storage)
        {
            _view = view;
            _storage = storage;
        }

        public void OnEnable()
        {
            _storage.OnGemChanged += OnMoneyChanged;
            _view.SetupMoney(_storage.Gem.ToString());
        }

        public void OnDisable()
        {
            _storage.OnGemChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            _view.UpdateMoney(money.ToString());
        }
    }
}