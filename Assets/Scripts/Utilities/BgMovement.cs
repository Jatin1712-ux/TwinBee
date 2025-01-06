using UnityEngine;

namespace Utilities
{
    public class BgMovement : MonoBehaviour
    {
        private MeshRenderer meshRenderer;

        public static float animationSpeed = 0.1f;

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            meshRenderer.material.mainTextureOffset += new Vector2(0, animationSpeed * Time.smoothDeltaTime);
        }
    }
}
