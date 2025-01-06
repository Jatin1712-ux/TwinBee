using UnityEngine;

namespace Enemies
{
    public class TanE : MonoBehaviour
    {
        float tanCenterX;
        public float amplitude = 1;
        public float frequency = 0.5f;
        private void Start()
        {
            tanCenterX = transform.position.x;
        }
        private void FixedUpdate()
        {
            Vector2 pos = transform.position;
            float tan = Mathf.Tan(pos.y * frequency) * amplitude;
            pos.x = tanCenterX - tan;
            transform.position = pos;

        }
    }
}
