using Sirenix.OdinInspector;
using UnityEngine;

namespace _PRESENTATION___MODEL_.Scripts
{
    [CreateAssetMenu(
        fileName = "Product",
        menuName = "Inventory/newProduct"
    )]
    public sealed class Product : ScriptableObject
    {
        [field: SerializeField, PreviewField] public Sprite Icon { get; private set; }
        [field: SerializeField, PreviewField] public Sprite CurrencyIcon { get; private set; }
        [field: SerializeField] public string Title { get; private set; }
        [field: SerializeField, TextArea] public string Description { get; private set; }
        [field: SerializeField, Space] public int Price { get; private set; }
    }
}