using UnityEngine;

namespace Enemies
{
    public class Destruct : MonoBehaviour
    {
        private void Update()
        {
        
            if(transform.childCount == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
