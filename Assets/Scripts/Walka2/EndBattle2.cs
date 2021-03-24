﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattle2 : MonoBehaviour
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
        if (Enemy2Script.e1currentHealth <= 0)
        {
            if (win == false)
            {
                win = true;


                {
                    EndBattlePanelWin.SetActive(true);
                    loot.Losowanie2();
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


    public void Battle2EndWin()
    {
        if (PlayerPrefs.GetInt("battlelevel") >= 4)
        {
            return;
        }
        PlayerPrefs.SetInt("battlelevel", 3);
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }

    public void Battle2EndLoose()
    {
        PlayerPrefs.SetInt("odpoczynek", 0);
        PlayerPrefs.Save();
    }

}
