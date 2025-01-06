using UnityEngine;
using UnityEngine.UI;

namespace Utilities
{
    public class ScoreDisplay : MonoBehaviour
    {
        public Text CurrentScore;
        public Text HighScore;

    

        public void Awake()
        {
            CurrentScore.text = PlayerPrefs.GetInt(Constant.CURRENTSCORE, 0).ToString(); 
            HighScore.text = PlayerPrefs.GetInt(Constant.HIGHSCORE, 0).ToString();   
        }
    
    }
}
