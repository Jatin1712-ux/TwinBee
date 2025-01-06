using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Utilities
{
    public class SfxSlider : MonoBehaviour
    {
        private float _vol;

        public AudioMixer audioMixer;
        public Slider sfx;

        public void Start()
        {
            _vol = PlayerPrefs.GetFloat(Constant.SFXVALUE, -40);
            sfx.value = _vol;
        }

        public void SetVolume(float volume)
        {
            sfx.value = volume;
            _vol = volume;
            audioMixer.SetFloat("Volume", volume);
            PlayerPrefs.SetFloat(Constant.SFXVALUE, volume);
        }
    }
}
