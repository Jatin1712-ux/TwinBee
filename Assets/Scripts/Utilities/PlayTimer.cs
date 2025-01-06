using UnityEngine;

namespace Utilities
{
    public class PlayTimer : MonoBehaviour
    {
        private float playtime = 0;

        private void Start()
        {
            playtime = PlayerPrefs.GetFloat(Constant.PLAYTIME, 0f);
        }
        private void Update()
        {
            playtime += Time.deltaTime;
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetFloat(Constant.PLAYTIME, playtime);
            PlayerPrefs.Save();
        }
    }
}
