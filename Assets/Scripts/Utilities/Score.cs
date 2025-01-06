using UnityEngine;
using UnityEngine.UI;

namespace Utilities
{
    public class Score : MonoBehaviour
    {
        public static int scoreValue ;
        Text score;
        public static int HighScore;
    
        void Start()
        {
            score = GetComponent<Text>();
            scoreValue = 0;
            HighScore =PlayerPrefs.GetInt(Constant.HIGHSCORE, 0);
        
        }

        // Update is called once per frame
        void Update()
        {
            if (scoreValue > PlayerPrefs.GetInt(Constant.HIGHSCORE, 0))
            {
                PlayerPrefs.SetInt(Constant.HIGHSCORE, scoreValue);
            }
            score.text = scoreValue.ToString();  
        }
    }
}
