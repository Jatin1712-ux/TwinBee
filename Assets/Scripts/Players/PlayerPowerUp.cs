using Clouds;
using Currency;
using UnityEngine;
using Utilities;

namespace Players
{
    public class PlayerPowerUp : MonoBehaviour
    {
        public static bool Power = false;
        [SerializeField]int index;
        public static bool heal = false;
        public GameObject shield;
        public static bool isShield = false;
        public static bool isPowerActive = false;
        private void Start()
        {
            shield = transform.Find("Shield").gameObject;
            shield.SetActive(false);
        }
    
        void ActivateShield()
        {
            shield.SetActive(true);
            isShield = true;
        }
        void IncreaseHealth()
        {
            Health.health += 1;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
        
            if (collision.gameObject.tag == "Bell")
            {
                var belsc =  collision.collider.GetComponent<HellsBells>();
                index = belsc.bellIndex;
                // print(index);
                if (index == 1)
                {
                    Coins.CoinValue += 10;
                    Score.scoreValue += 100;
                    PlayerPrefs.SetInt(Constant.COINS, Coins.CoinValue);
                }
                else if (index == 2)
                {
                    ActivateShield();
                    Coins.CoinValue += 20;
                    Score.scoreValue += 200;
                    PlayerPrefs.SetInt(Constant.COINS, Coins.CoinValue);
                    isPowerActive = true;
                }
                else if (index == 3)
                {
                    SfxManager.Instance.PlaySound("Heal");
                    //print("KK");
                    //heal = true;
                    IncreaseHealth();
                    Coins.CoinValue += 25;
                    Score.scoreValue += 250;
                    PlayerPrefs.SetInt(Constant.COINS, Coins.CoinValue);
                    //isPowerActive = true;
                }
                else if (index == 4)
                {
                    Power = true;
                    Coins.CoinValue += 30;
                    Score.scoreValue += 300;
                    PlayerPrefs.SetInt(Constant.COINS, Coins.CoinValue);
                    isPowerActive = true;
                }

            }
        }
    }
}
    

