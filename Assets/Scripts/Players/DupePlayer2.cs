using UnityEngine;
using Utilities;

namespace Players
{
    public class DupePlayer2 : MonoBehaviour
    {
        private float deltaX;
        private float deltaY;
        private Rigidbody2D rb;
        public GameObject dp2;
        public GameObject dp1;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();

        }
        private void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                Vector2 touchpos = Camera.main.ScreenToWorldPoint(touch.position);
                if (touchpos.y > 1)
                {
                    return;
                }
                Vector2 offsetPos = Camera.main.ScreenToWorldPoint(touch.position - new Vector2(deltaX, deltaY));

                switch (touch.phase)
                {
                    case TouchPhase.Began:

                        deltaX = touchpos.x - transform.position.x;
                        deltaY = touchpos.y - transform.position.y;
                        //print(deltaY);
                        rb.position = offsetPos + new Vector2(-0.9f, 1f);
                        break;
                    case TouchPhase.Moved:
                        rb.MovePosition(new Vector2(offsetPos.x - 0.9f, offsetPos.y + 1f));
                        break;
                    case TouchPhase.Stationary:
                        rb.position = offsetPos + new Vector2(-0.9f, 1f);
                        break;
                    case TouchPhase.Ended:
                        rb.velocity = Vector2.zero;
                        break;
                    case TouchPhase.Canceled:
                        break;
                }
            }

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bell")
            {
                Score.scoreValue += 150;

            }
            if (collision.gameObject.tag == "Enemy")
            {
                PlayerPowerUp.isPowerActive = false;
                PlayerPowerUp.Power = false;
                dp2.SetActive(false);
                dp1.SetActive(false);
            }
            if (collision.gameObject.tag == "EnemyBullet")
            {
                PlayerPowerUp.isPowerActive = false;
                PlayerPowerUp.Power = false;
                dp1.SetActive(false);
                dp2.SetActive(false);
            }
        }
    }
}
