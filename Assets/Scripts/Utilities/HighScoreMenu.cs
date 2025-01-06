using UnityEngine;
using UnityEngine.UI;

namespace Utilities
{
    public class HighScoreMenu : MonoBehaviour
    {
        public Text highScore;
        public Text coinText;
    
        private void Start()
        {
            highScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt(Constant.HIGHSCORE).ToString();
            coinText.text = "COINS: " + PlayerPrefs.GetInt(Constant.COINS, 0).ToString();
        }
    }
}
