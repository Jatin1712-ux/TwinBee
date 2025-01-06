using UnityEngine;

namespace Enemies
{
    public class BulletEnemy : MonoBehaviour
    {
        private Rigidbody2D rb;

        [SerializeField] private float bulletSpeed = 10f;

        [SerializeField] private float maxLifetime = 3f;

        // Vector2 dir = new Vector2();
        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            Project(-transform.up);
        }

        public void Project(Vector2 direction)
        {
            rb.AddForce(direction * this.bulletSpeed, ForceMode2D.Impulse);

            Destroy(this.gameObject, maxLifetime);
        }

    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player" )
            {
                Destroy(this.gameObject);
            }
            if(collision.gameObject.tag == "Enemy")
            {
                Destroy(this.gameObject);
            }
            if(collision.gameObject.tag == "Shield")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
