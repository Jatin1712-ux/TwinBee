using UnityEngine;

namespace Utilities
{
    public class SfxManager : MonoBehaviour
    {
        public static SfxManager Instance;
        public AudioSource audioSource;
        public AudioClip[] sfxSource;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlaySound(string audioName)
        {
            foreach (var clip in sfxSource)
            {
                if (clip.name.Contains(audioName))
                {
                    audioSource.PlayOneShot(clip);
                }
            }
        }
    }
}
