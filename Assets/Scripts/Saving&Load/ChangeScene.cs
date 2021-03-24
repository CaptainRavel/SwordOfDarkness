using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ChangeScene : MonoBehaviour
{

    public void btn_change_scene(string scene_name)
    {
        StartCoroutine(DelaySceneLoad());
        IEnumerator DelaySceneLoad()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene(scene_name);
        }

    }
    public void battle_change_scene(string scene_name)
    {
        StartCoroutine(DelaySceneLoad());
        IEnumerator DelaySceneLoad()
        {
            yield return new WaitForSeconds(1.7f);
            SceneManager.LoadScene(scene_name);
        }

    }
    public void winorloose_change_scene(string scene_name)
    {
        StartCoroutine(DelaySceneLoad());
        IEnumerator DelaySceneLoad()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene(scene_name);
        }

    }

    public void NewGame()
    {
        PlayerPrefs.DeleteKey("ContinueGame");
        PlayerPrefs.DeleteKey("CaHON");
        PlayerPrefs.DeleteKey("battlelevel");
        PlayerPrefs.DeleteKey("levelup");
        PlayerPrefs.DeleteKey("pendHP");
        PlayerPrefs.DeleteKey("pendKON");
        PlayerPrefs.DeleteKey("maartefakt");
        PlayerPrefs.SetInt("odpoczynek", 1);
        PlayerPrefs.SetInt("firstplaygame", 1);
        PlayerPrefs.Save();
    }
}
