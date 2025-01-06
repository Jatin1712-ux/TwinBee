using UnityEngine;

namespace Utilities
{
    public class LIfeTime : MonoBehaviour
    {
        public float lifeTime = 0.3f;

        private void Start()
        {
            Destroy(gameObject, lifeTime);
        }
    }
}
