using Currency;
using UnityEngine;
using Utilities;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        public GameObject explosionPrefab;
    

        public void Explosion()
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print(collision.collider.name);
            if(collision.gameObject.CompareTag("Bullet"))
            {
                SfxManager.Instance.PlaySound("Explosion");
                Score.scoreValue += 100;
                Coins.CoinValue += 5;
                PlayerPrefs.SetInt(Constant.COINS, Coins.CoinValue);
                Explosion();
                Destroy(this.gameObject);
            }
            if(collision.gameObject.CompareTag("Player"))
            {
                SfxManager.Instance.PlaySound("Explosion");
                Explosion();
                Destroy(this.gameObject);
            }
            if(collision.gameObject.CompareTag("Shield"))
            {
                SfxManager.Instance.PlaySound("Explosion");
                Explosion();
                Destroy(this.gameObject);
            }
            if(collision.gameObject.CompareTag("DuplicatePlayer") )
            {
                SfxManager.Instance.PlaySound("Explosion");
                Explosion();
                Destroy(this.gameObject);
            }
        }
    }
}
