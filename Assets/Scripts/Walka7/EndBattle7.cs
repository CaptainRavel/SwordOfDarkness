using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattle7 : MonoBehaviour
{
    public GameObject EndBattlePanelWin;
    public GameObject EndBattlePanelLoose;
    public LootSystem loot;
    
    public static int endHP;
    public static int endKon;
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
        if (Enemy7Script.e1currentHealth <= 0)
        {
            if (win == false)
            {
                win = true;


                {
                    EndBattlePanelWin.SetActive(true);
                    loot.Losowanie7A();
                    loot.Losowanie7B();
                    loot.CzyMaArtefakt();
                }
            }
        }
            if (PlayerBattle.pcurrhealth <= 0)
            {
                EndBattlePanelLoose.SetActive(true);

            }
        
    }

    public void NextLevel()
    {
        PlayerPrefs.SetInt("levelup", 1);
        PlayerPrefs.Save();
    }


    public void Battle7EndWin()
    {

        PlayerPrefs.SetInt("battlelevel", 8); 
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }

    public void Battle7EndLoose()
    {

        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }

}
