using System;
using UnityEngine;
using UnityEngine.UI;

namespace Utilities
{
    public class PlayTImeSetter : MonoBehaviour
    {
        public Text timertext;
        private TimeSpan ts;
    
        private void Start()
        {
            float seconds  = PlayerPrefs.GetFloat(Constant.PLAYTIME, 0f);

            ts = TimeSpan.FromSeconds(seconds);

            int hours = (int)ts.TotalHours;
            float mins = ts.Minutes;
            float secs = ts.Seconds;
        
            string secon =  secs.ToString();
            string mini = mins.ToString();
            string hrs = hours.ToString();

            if (secs < 10)
            {
                secon = "0" + secon;
            }

            if (mins < 10)
            {
                mini = "0" + mini;
            }

            if (hours < 10)
            {
                hrs = "0"+ hours;
            }

            timertext.text = "TIME PLAYED- " + hrs + ":" + mini + ":" + secon;
        }
    
    }
}
