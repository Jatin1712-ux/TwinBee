using UnityEngine;

namespace Players
{
    public class ShieldTimer : MonoBehaviour
    {
        public GameObject shield;
        public float currentTIme = 0f;
        public float startingTIme = 45f;

        private void OnEnable()
        {   
            currentTIme = startingTIme;          
        }
        private void Update()
        {
            if(PlayerPowerUp.isShield == true)
            {
                currentTIme -= 1 * Time.deltaTime;
                if(currentTIme <= 0)
                {
                    currentTIme = 0;
                }
                if(currentTIme == 0)
                {
                    PlayerPowerUp.isPowerActive = false;
                    shield.SetActive(false);
                    PlayerPowerUp.isShield = false;               
                }
            }
        }

    }
}
