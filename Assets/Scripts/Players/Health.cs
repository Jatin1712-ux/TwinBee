using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Utilities;

namespace Players
{
    public class Health : MonoBehaviour
    {
        public static int health ;

        public int numOfHearts;

        public Image[] hearts;

        public Sprite fullHeart;

        public GameObject player;

        public Animator crossfade;

        public void Start()
        {
            health = 3;
        }
        private void Update()
        {
        
            if (health > numOfHearts)
            {
                health = numOfHearts;
            }
            if(health <= 0)
            {
                health = 0;
            }
            for (int i = 0; i < hearts.Length; i++)
            {

                if (i < health)
                {
                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }
            }
            if(health == 0)
            {
                player.SetActive(false);
            }
        }

        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(PlayerPowerUp.isShield == false)
            {
                if (collision.gameObject.tag == "EnemyBullet")
                {
                    health--;
                }
                if (collision.gameObject.tag == "Enemy")
                {
                    health--;
                }
            }
       
        }
    }
}
