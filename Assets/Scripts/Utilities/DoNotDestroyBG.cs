using UnityEngine;

namespace Utilities
{
    public class DoNotDestroyBG : MonoBehaviour
    {
        private void Awake()
        {
            GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BGMusic");
            if (musicObj.Length > 1)
            {
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
