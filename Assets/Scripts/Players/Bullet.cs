using UnityEngine;

namespace Players
{
    public class Bullet : MonoBehaviour
    {
        private Rigidbody2D rb;

        [SerializeField] private float bulletSpeed = 70f;

        [SerializeField] private float maxLifetime = 3f;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        public void Update()
        {
            Vector2 pos = transform.position;

            if(pos.y > 4.4f)
            {
                Destroy(this.gameObject);
            }
        }

        public void Project(Vector2 direction)
        {
            rb.AddForce(direction * this.bulletSpeed , ForceMode2D.Impulse);

            Destroy(this.gameObject, maxLifetime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.collider.name);
            Destroy(this.gameObject);  
        }
    }
}
