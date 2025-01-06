using UnityEngine;

namespace Clouds
{
    public class HellsBells : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        public Animator animator;

        public Rigidbody2D rb;
  
        private int hitIndex;

        public float fallSpeed = 5f;

        public float bottomEdge;
        public  int bellIndex;
        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            bottomEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y - 1f;
            rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
       
            transform.position += Vector3.down * fallSpeed * Time.deltaTime;

            if (transform.position.y < bottomEdge)
            {
                Destroy(gameObject);
            }
            if(hitIndex >= 0 && hitIndex < 2)
            {
                bellIndex = 1;
                //ORANGE
            
            
            }
            else if(hitIndex >=2 && hitIndex < 5)
            {
                animator.SetBool("HIT2", true);
                bellIndex = 2;
                //PINK
            
            }
            else if(hitIndex >= 5 && hitIndex < 7)
            {
                animator.SetBool("HIT2", false);
                animator.SetBool("HIT4", true);
                bellIndex = 3;
                //BLUE
            
            }
            else if(hitIndex >= 7)
            {
                animator.SetBool("HIT2", false);
                animator.SetBool("HIT4", false);
                animator.SetBool("HIT6", true);
                bellIndex = 4;
                //WHITE
            
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                hitIndex++;
            }
            if (collision.gameObject.tag == "Player")
            {

                Destroy(this.gameObject);
            }
            if(collision.gameObject.tag == "DuplicatePlayer")
            {
                Destroy(this.gameObject);
            }
        
        }

    }
}
