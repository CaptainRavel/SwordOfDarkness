using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattle : MonoBehaviour
{
    public GameObject EndBattlePanelWin;
    public GameObject EndBattlePanelLoose;
    public LootSystem loot;
    
    public static int endHP;
    public static int endKon;
	public static int battewin = 0;
    private bool win;

    public GameObject gracz;
    public GameObject wrog;
    public GameObject optionspanel;
    public GameObject winpanel;
    public GameObject loosepanel;




    void Start()
    {
    }

    void Update()
    {

        if (optionspanel.activeSelf)
        {
            gracz.SetActive(false);
            wrog.SetActive(false);
        }
        else
        {
            gracz.SetActive(true);
            wrog.SetActive(true);
        }
        if (winpanel.activeSelf)
        {
            gracz.SetActive(false);
            wrog.SetActive(false);
        }
        else
        {
            gracz.SetActive(true);
            wrog.SetActive(true);
        }
        if (loosepanel.activeSelf)
        {
            gracz.SetActive(false);
            wrog.SetActive(false);
        }
        else
        {
            gracz.SetActive(true);
            wrog.SetActive(true);
        }
        if (Enemy1Script.e1currentHealth <= 0)
        {
            Enemy1Script.e1currentHealth = 0;
            if (win == false)
            {
                win = true;


                {
                    EndBattlePanelWin.SetActive(true);
                    loot.Losowanie1();
                }
            }
        }
            if (PlayerBattle.pcurrhealth <= 0)
            {
            PlayerBattle.pcurrhealth = 0;
                EndBattlePanelLoose.SetActive(true);

            }
        
    }
	/*    public void StartTimer() //Call this from OnClick
    {
        turaButton.interactable = false;
        Invoke("EndTimer", 3f);
    }

    private void EndTimer()
    {
        turaButton.interactable = true;
    }
    */
    public void NextLevel()
    {
        PlayerPrefs.SetInt("levelup", 1);
        PlayerPrefs.Save();
		
    }

    public void Battle1EndWin()
    {
        if (PlayerPrefs.GetInt("battlelevel") >= 3)
        {
            return;
        }
        else
        {
            PlayerPrefs.SetInt("battlelevel", 2);
            PlayerPrefs.SetInt("odpoczynek", 0);
            PlayerPrefs.Save();
        }
    }
    public void Battle2EndWin()
    {
        PlayerPrefs.SetInt("battlelevel", 3);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle3EndWin()
    {
        PlayerPrefs.SetInt("battlelevel", 4);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle4EndWin()
    {
        PlayerPrefs.SetInt("battlelevel", 5);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle5EndWin()
    {
        PlayerPrefs.SetInt("battlelevel", 6);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle6EndWin()
    {
        PlayerPrefs.SetInt("battlelevel", 7);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle7Win()
    {
        PlayerPrefs.SetInt("battlelevel", 7);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle1EndLoose()
    {
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle2EndLoose()
    {
        PlayerPrefs.SetInt("battlelevel", 2);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle3EndLoose()
    {
        PlayerPrefs.SetInt("battlelevel", 3);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle4EndLoose()
    {
        PlayerPrefs.SetInt("battlelevel", 4);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle5EndLoose()
    {
        PlayerPrefs.SetInt("battlelevel", 5);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle6EndLoose()
    {
        PlayerPrefs.SetInt("battlelevel", 6);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
    public void Battle7Loose()
    {
        PlayerPrefs.SetInt("battlelevel", 7);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }
}
