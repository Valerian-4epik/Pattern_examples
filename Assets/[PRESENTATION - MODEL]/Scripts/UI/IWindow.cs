using UnityEngine;

namespace _PRESENTATION___MODEL_.Scripts.UI
{
    public interface IWindow
    {
        void Show(object args);
        void Hide();
    }
}