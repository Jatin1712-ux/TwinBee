using Players;
using UnityEngine;

namespace Utilities
{
    public class GameManager : MonoBehaviour
    {
        public GameObject Firebutton;
        public GameObject dupePlayer1;
        public GameObject dupePlayer2;
    
        bool isPower;

        private void Start()
        {
            Firebutton.SetActive(false);
            dupePlayer1.SetActive(false);
            dupePlayer2.SetActive(false);
       
        }
    
        private void Update()
        {
            if(Input.touchCount > 0)
            {
                Firebutton.SetActive(true);
            }
            else
            {
                Firebutton.SetActive(false);
            }

            isPower = PlayerPowerUp.Power;

            if(isPower == true)
            {
                PowerDupe();
            }

        }
        private void PowerDupe()
        {
            dupePlayer1.SetActive(true);
            dupePlayer2.SetActive(true);
        }
    }
}
