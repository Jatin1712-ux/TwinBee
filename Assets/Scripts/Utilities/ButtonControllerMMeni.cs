using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utilities
{
    public class ButtonControllerMMeni : MonoBehaviour
    {
        public Animator crossfade;
        public void Play()
        {
            SfxManager.Instance.PlaySound("Click");
            StartCoroutine(LoadLevel("Game"));
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void Shop()
        {
            SfxManager.Instance.PlaySound("Click");
            StartCoroutine(LoadLevel("Shop"));
        }

        IEnumerator LoadLevel(string Name)
        {
            crossfade.SetTrigger("Start");

            yield return new WaitForSeconds(0.5f);

            SceneManager.LoadScene(Name);
        }
    }
}
