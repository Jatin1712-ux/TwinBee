using System;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

namespace Currency
{
    public class Coins : MonoBehaviour
    {
        public static int CoinValue;
        public Text coinText;

        private void Start()
        {
            coinText = GetComponent<Text>();
            CoinValue = PlayerPrefs.GetInt(Constant.COINS, 0);
        }

        private void Update()
        {
            coinText.text = "COINS: " + CoinValue.ToString();
        }
    }
}
