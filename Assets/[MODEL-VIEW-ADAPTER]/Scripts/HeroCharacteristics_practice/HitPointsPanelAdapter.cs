using _MODEL_VIEW_ADAPTER_.Scripts.MonoContext;

namespace _MODEL_VIEW_ADAPTER_.Scripts.HeroCharacteristics_practice
{
    public class HitPointsPanelAdapter : IEnableComponent, IDisableComponent
    {
        private readonly StatPanel _view;
        private readonly Character _character;
        
        public HitPointsPanelAdapter(StatPanel view, Character character)
        {
            _view = view;
            _character = character;
        }

        public void OnEnable()
        {
            _character.OnHitPointsChanged += OnHitPointsChanged;
            _view.SetupText(_character.GetHitPoints().ToString());
        }

        public void OnDisable()
        {
            _character.OnHitPointsChanged -= OnHitPointsChanged;
        }

        private void OnHitPointsChanged(float hitValue)
        {
            _view.UpdateText(hitValue.ToString());
        }
    }
}