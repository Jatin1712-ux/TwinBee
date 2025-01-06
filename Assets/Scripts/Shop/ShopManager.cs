using UnityEngine;
using UnityEngine.UI;
using Utilities;
using Button = UnityEngine.UI.Button;

namespace Shop
{
    public class ShopManager : MonoBehaviour
    {
        public int coins;
        public Text coinDisplay;
        public static bool SkinSelected;

            public ShopItems[] shopItems;
        public GameObject[] shopPanelsGo;
        public ShopTemplate[] shopPanels;
        public Button[] purchaseButtons;
        public Button[] selectButtons;
        public Text[] costText;

        private void Start()
        {
            coins = PlayerPrefs.GetInt(Constant.COINS, 0);
            coinDisplay.text ="COINS: " + coins.ToString();
            UpdateUI();
            LoadPanels();
            CheckPurchaseable();
        }

        private void UpdateUI()
        {
            for (int i = 0; i < shopPanelsGo.Length; i++)
            {
                shopPanelsGo[i].SetActive(true);
                if (PlayerPrefs.GetInt(i.ToString(),0) == 1)
                {
                    purchaseButtons[i].gameObject.SetActive(false);
                    costText[i].gameObject.SetActive(false);
                    selectButtons[i].gameObject.SetActive(true);
                }
                else
                {
                    purchaseButtons[i].gameObject.SetActive(true);
                    costText[i].gameObject.SetActive(true);
                    selectButtons[i].gameObject.SetActive(false);
                }
            }
        }

        public void CheckPurchaseable()
        {
            for (int i = 0; i < shopItems.Length; i++)
            {
                if (coins > shopItems[i].price)
                {
                    purchaseButtons[i].interactable = true;
                }
                else
                {
                    purchaseButtons[i].interactable = false;
                }
            }
        }

        public void PurchaseItems(int btnNo)
        {
            if (coins >= shopItems[btnNo].price )
            {
                coins = coins - shopItems[btnNo].price;
                PlayerPrefs.SetInt(Constant.COINS, coins);
                coinDisplay.text = "COINS: " + PlayerPrefs.GetInt(Constant.COINS, 0).ToString();
                PlayerPrefs.SetInt(btnNo.ToString(), 1);
                UpdateUI();
                CheckPurchaseable();
            }
        }
        
        public void LoadPanels()
        {
            for (int i = 0; i < shopItems.Length; i++)
            {
                shopPanels[i].titleText.text = shopItems[i].title;
                shopPanels[i].costText.text = shopItems[i].price.ToString();
            }
        }

        public void SelectSkin(int btno)
        {
           PlayerPrefs.SetInt(Constant.SKIN , btno);
           SkinSelected = true;
        }
        
    }
}

