using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utilities
{
    public class Button : MonoBehaviour
    {
        public Animator crossfade;
        public void Restart()
        {
            SfxManager.Instance.PlaySound("Click");
            StartCoroutine(LoadLevel("Game"));
        }
    
        public void Menu()
        {
            SfxManager.Instance.PlaySound("Click");
            StartCoroutine(LoadLevel("MainMenu"));
        }

        IEnumerator LoadLevel(string name)
        {
            crossfade.SetTrigger("Start");

            yield return new WaitForSeconds(0.5f);

            SceneManager.LoadScene(name);
        }
    }
}
