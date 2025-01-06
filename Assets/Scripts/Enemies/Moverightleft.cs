using UnityEngine;

namespace Enemies
{
    public class Moverightleft : MonoBehaviour
    {
        public float moveSPeed = 5;

        private void FixedUpdate()
        {
            Vector2 pos = transform.position;
            pos.y -= moveSPeed * Time.deltaTime;
            if(pos.y < -5)
            {
                Destroy(this.gameObject);
            }
            transform.position = pos;
        }
    }
}
