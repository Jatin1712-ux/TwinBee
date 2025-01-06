using System;
using UnityEngine;
using UnityEngine.UI;

namespace Utilities
{
    public class BgSlider : MonoBehaviour
    {
        private int _firstPlayInt;
        private float _bgFloat;

        public Slider bgSLi;

        public AudioSource bgAudio;

        private void Start()
        {
            bgAudio = GameObject.FindGameObjectWithTag("BGMusic").GetComponent<AudioSource>();

            _firstPlayInt = PlayerPrefs.GetInt(Constant.FIRSTPLAY, 0);

            if (_firstPlayInt == 0)
            {
                _bgFloat = 0.25f;
                bgSLi.value = _bgFloat;
                
                PlayerPrefs.SetFloat(Constant.BGVALUE, _bgFloat);
                PlayerPrefs.SetInt(Constant.FIRSTPLAY,-1);
            }
            else
            {
                _bgFloat = PlayerPrefs.GetFloat(Constant.BGVALUE, 0);
                bgSLi.value = _bgFloat;
                bgAudio.volume = bgSLi.value;
            }
        }

        public void SaveSoundSettings()
        {
            PlayerPrefs.SetFloat(Constant.BGVALUE , bgSLi.value);
            PlayerPrefs.Save();
        }

        public void UpdateSound()
        {
            bgAudio.volume = bgSLi.value;
            SaveSoundSettings();
        }

        private void OnDestroy()
        {
            SaveSoundSettings();
        }
    }
}
