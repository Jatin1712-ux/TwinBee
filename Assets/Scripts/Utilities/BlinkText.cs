using UnityEngine;
using UnityEngine.UI;

namespace Utilities
{
    public enum alphaValue
    {
        SHRINKING,
        GROWING
    }

    public class BlinkText : MonoBehaviour
    {
        public alphaValue currentAlphaValue;
        public float CommentMinAlpha;
        public float CommentMaxAlpha;
        public float CommentCurrentAlpha;
        public Text myText;

        private void Start()
        {
            CommentMinAlpha = 0.2f;
            CommentMaxAlpha = 1f;
            CommentCurrentAlpha = 1f;
            currentAlphaValue = alphaValue.SHRINKING;
        }

        private void Update()
        {
            AlphaComments();
        }

        public void AlphaComments()
        {
            if (currentAlphaValue == alphaValue.SHRINKING)
            {
                CommentCurrentAlpha = CommentCurrentAlpha - 0.01f;
                myText.color = new Color(Color.white.r, Color.white.g, Color.white.b, CommentCurrentAlpha);
                if (CommentCurrentAlpha <= CommentMinAlpha)
                {
                    currentAlphaValue = alphaValue.GROWING;
                }
            }
            else if (currentAlphaValue == alphaValue.GROWING)
            {
                CommentCurrentAlpha = CommentCurrentAlpha + 0.01f;
                myText.color = new Color(Color.white.r, Color.white.g, Color.white.b, CommentCurrentAlpha);
                if (CommentCurrentAlpha >= CommentMaxAlpha)
                {
                    currentAlphaValue = alphaValue.SHRINKING;
                }
            }
        }

    }
}