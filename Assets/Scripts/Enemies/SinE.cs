using UnityEngine;

namespace Enemies
{
    public class SinE : MonoBehaviour
    {
        float sinCenterX;
        public float amplitude = 1f;
        public float frequency = 2f;
        private void Start()
        {
            sinCenterX = transform.position.x;
        }
        private void FixedUpdate()
        {
            Vector2 pos = transform.position;
            float sin = Mathf.Sin(pos.y * frequency) * amplitude;
            pos.x = sinCenterX + sin;
            transform.position = pos;
        
        }
    }
}
