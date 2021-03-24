using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstOpening : MonoBehaviour
{
    public GameObject FirstPlay;

    public void Load_change_scene(string scene_name)
    {
        StartCoroutine(DelaySceneLoad());
        IEnumerator DelaySceneLoad()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene(scene_name);
        }

    }
    public void FirstGame()
    {
        if (PlayerPrefs.GetInt("firstplaygame") != 1)
        {
            FirstPlay.SetActive(true);
        }
        else
        {
            Load_change_scene("Game");
        }
    }
}
