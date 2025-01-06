using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

public class ShopButtonController : MonoBehaviour
{
   public Animator crossfade;
   public void Return()
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
