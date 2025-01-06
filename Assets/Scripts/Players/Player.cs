using UnityEngine;

namespace Players
{
    public class Player : MonoBehaviour
    {
        private float deltaX;
        private float deltaY;
        private Rigidbody2D rb;

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
                        rb.position = offsetPos + new Vector2(0, 1f);
                        break;
                    case TouchPhase.Moved:
                        rb.MovePosition(new Vector2(offsetPos.x, offsetPos.y + 1f));
                        break;
                    case TouchPhase.Stationary:
                        rb.position = offsetPos + new Vector2(0, 1f);
                        break;
                    case TouchPhase.Ended:
                        rb.velocity = Vector2.zero;
                        break;
                    case TouchPhase.Canceled:
                        break;
                }
            }

        }
    }
}
