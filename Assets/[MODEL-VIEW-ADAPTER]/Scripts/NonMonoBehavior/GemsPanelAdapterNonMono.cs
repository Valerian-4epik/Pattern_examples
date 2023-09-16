namespace _MODEL_VIEW_ADAPTER_.Scripts.NonMonoBehavior
{
    public sealed class GemsPanelAdapterNonMono
    {
        private readonly CurrencyPanel _view;
        private readonly GemStorage _storage;

        public GemsPanelAdapterNonMono(CurrencyPanel view, GemStorage storage)
        {
            _view = view;
            _storage = storage;
        }

        public void Enable()
        {
            _storage.OnGemChanged += OnMoneyChanged;
            _view.SetupMoney(_storage.Gem.ToString());
        }

        public void Disable()
        {
            _storage.OnGemChanged -= OnMoneyChanged;
        }

        private void OnMoneyChanged(int money)
        {
            _view.UpdateMoney(money.ToString());
        }
    }
}