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
        [SerializeField, PreviewField]
        public Sprite Icon;
    }
}