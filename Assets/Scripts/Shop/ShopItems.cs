using UnityEngine;

namespace Shop
{
    [CreateAssetMenu(fileName = "ShopMenu", menuName = "Scriptable Objects/New shop item", order = 1)]
    public class ShopItems : ScriptableObject
    {
        public string title;
        public int price;
    }
}

