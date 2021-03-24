using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleButtons : MonoBehaviour
{
    public Button battle2;
    public Button battle3;
    public Button battle4;
    public Button battle5;
    public Button battle6;
    public Button battle7;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("battlelevel", 1);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("battlelevel") == 1)
        {
            battle2.interactable = false;
            battle3.interactable = false;
            battle4.interactable = false;
            battle5.interactable = false;
            battle6.interactable = false;
            battle7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 2)
        {
            battle2.interactable = true;
            battle3.interactable = false;
            battle4.interactable = false;
            battle5.interactable = false;
            battle6.interactable = false;
            battle7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 3)
        {
            battle2.interactable = true;
            battle3.interactable = true;
            battle4.interactable = false;
            battle5.interactable = false;
            battle6.interactable = false;
            battle7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 4)
        {
            battle2.interactable = true;
            battle3.interactable = true;
            battle4.interactable = true;
            battle5.interactable = false;
            battle6.interactable = false;
            battle7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 5)
        {
            battle2.interactable = true;
            battle3.interactable = true;
            battle4.interactable = true;
            battle5.interactable = true;
            battle6.interactable = false;
            battle7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 6)
        {
            battle2.interactable = true;
            battle3.interactable = true;
            battle4.interactable = true;
            battle5.interactable = true;
            battle6.interactable = true;
            battle7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 7)
        {
            battle2.interactable = true;
            battle3.interactable = true;
            battle4.interactable = true;
            battle5.interactable = true;
            battle6.interactable = true;
            battle7.interactable = true;
        }
    }
}
