using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGameScript : MonoBehaviour
{
 

    private int isON = 1;
    private int continueGame = 1;

    public void DestroyCaH()
    {
        PlayerPrefs.SetInt("CaHON", isON);
        PlayerPrefs.Save();
    }

    public void ContinueGame()
    {
        PlayerPrefs.SetInt("ContinueGame", continueGame);
        PlayerPrefs.Save();
    }

    public void PrefsTest()
    {
        Debug.Log(PlayerPrefs.GetInt("battlelevel"));

    }

    public void Load_change_scene(string scene_name)
    {
        StartCoroutine(DelaySceneLoad());
        IEnumerator DelaySceneLoad()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene(scene_name);
        }

    }


}