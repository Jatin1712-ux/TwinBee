using System;
using System.Collections;
using System.Collections.Generic;
using Players;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

public class Die : MonoBehaviour
{
    public Animator crossfade;

    private void Update()
    {
        if (Health.health ==  0)
        {
            PlayerPrefs.SetInt(Constant.CURRENTSCORE, Score.scoreValue);
            SfxManager.Instance.PlaySound("Explosion");
            StartCoroutine(LoadLevel("GameOverScreen"));
            //GameOver Screen
        }
    }
    IEnumerator LoadLevel(string name)
    {
        crossfade.SetTrigger("Start");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(name);
            
    }
}
