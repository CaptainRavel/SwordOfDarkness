using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerUIScript : MonoBehaviour
{
    System.Random rnd = new System.Random();
    public Slider HealthBar;
    public Text HPText;

    public Slider KonBar;
    public Text KonText;

    public Text LvlText;

    static public int siła;
    static public int zrecznosc;
    static public int wytrzymalosc;
    static public int refleks;
    static public int maxzdrowie;
    static public int maxkon;
    static public int currzdrowie;
    static public int currkon;
    static public int gardapercent;
    static public int kontrapercent;
    private int poziom;
    static public int obrazeniamin;
    static public int obrazeniamax;

    void Start()
    {

    }

    void Update()
    {
        poziom = Character.level;
        LvlText.text = "POZIOM - " + poziom.ToString();

        maxkon = (int)Character.maxKon;
        maxzdrowie = (int)Character.maxHealth;

        if (PlayerPrefs.GetInt("odpoczynek") != 1)
        {
            currzdrowie= PlayerPrefs.GetInt("pendHP");
            if (currzdrowie <= 0)
            {
                currzdrowie = 0;
            }
            currkon = PlayerPrefs.GetInt("pendKON");
            if (currkon <=0)
            {
                currkon = 0;
            }

        }
        else if (PlayerPrefs.GetInt("odpoczynek") == 1)
        {
            currzdrowie = (int)Character.currentHealth;

            currkon = (int)Character.currentKon;

        }

        HealthBar.value = currzdrowie;
        HealthBar.maxValue = maxzdrowie;
        HPText.text = currzdrowie + "/" + maxzdrowie;
        KonBar.value = currkon;
        KonBar.maxValue = maxkon;
        KonText.text = currkon + "/" + maxkon;
        obrazeniamin = (int)Character.obrmin;
        obrazeniamax = (int)Character.obrmax;
        AdjustCurrentHealth(0);
        AdjustCurrentHealth(0);
    }

    public void AdjustCurrentHealth(int adj)
    {
        currzdrowie += adj;

        if (currzdrowie < 1)
        {
            currzdrowie = 0;
        }

        if (currzdrowie > maxzdrowie)
        {
            currzdrowie = maxzdrowie;
        }

        if (maxzdrowie < 1)
        {
            maxzdrowie = 1;
        }
    }
    public void AdjustCurrentCondition(int adj)
    {
        currkon += adj;

        if (currkon < 1)
        {
            currkon = 0;
        }

        if (currkon > maxkon)
        {
            currkon = maxkon;
        }

        if (maxkon < 1)
        {
            maxkon = 1;
        }
    }

    public void Odpoczynek()
    {
        PlayerPrefs.DeleteKey("endbattle");
        PlayerPrefs.SetInt("odpoczynek", 1);
        PlayerPrefs.Save();
    }
}


