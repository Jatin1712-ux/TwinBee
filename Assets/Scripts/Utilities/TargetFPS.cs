using UnityEngine;

namespace Utilities
{
    public class TargetFPS : MonoBehaviour
    {
        private void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 120;
        }
    }
}
