using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerBattle : MonoBehaviour
{
    static public int plevel;
    static public int psiła;
    static public int pzrecznosc;
    static public int pwytrzymalosc;
    static public int prefleks;
    static public float pgarda;
    static public float pkontratak;
    static public int pcurrhealth;
    static public int pmaxhealth;
    static public int pcurrkon;
    static public int pmaxkon;
    static public int pobrmin;
    static public int pobrmax;
    static public float gardepercent;
    static public float counterpercent;
    private int imgnum;
    static public float playerobr;
    private string hName;
    public static float pregeneracjakondycji;
    static public int endbattlehealth;
    static public int endbattlekon;

    [SerializeField]
    public Slider HealthBar;
    [SerializeField]
    public Text HPText;
    [SerializeField]
    public Slider KonBar;
    [SerializeField]
    public Text KonText;
    [SerializeField]
    public Text LvlText;
    [SerializeField]
    private GameObject img1;
    [SerializeField]
    private GameObject img2;
    [SerializeField]
    private GameObject img3;
    [SerializeField]
    private GameObject img4;
    [SerializeField]
    private GameObject img5;
    [SerializeField]
    private GameObject img6;
    [SerializeField]
    private GameObject img7;
    [SerializeField]
    private GameObject img8;
    [SerializeField]
    private GameObject img9;
    [SerializeField]
    private GameObject img10;
    [SerializeField]
    private GameObject img11;
    [SerializeField]
    private GameObject img12;
    [SerializeField]
    private Text hero;
    [SerializeField]


    void Start()
    {
        PlayerSaveScript data1 = PlayerSaving.LoadPlayer1();
        psiła = data1.siła;
        pzrecznosc = data1.zręcznosc;
        pwytrzymalosc = data1.wytrzymalosc;
        prefleks = data1.refleks;
        pgarda = data1.grada;
        pkontratak = data1.kontratak;
        pobrmin = data1.obrazeniaMin;
        pobrmax = data1.obrazeniaMax;
        pcurrhealth = data1.currentHP;
        pmaxhealth = data1.maxHP;
        pmaxkon = data1.maxKon;
        pcurrkon = data1.currentKon;
        plevel = data1.level;

        PlayerSaveScript data2 = PlayerSaving.LoadPlayer2();
        hName = data2.pName;
        imgnum = data2.pImageNumber;

    }

    void Update()
    {

        pregeneracjakondycji = 0.01f;
        gardepercent = pgarda * 0.01f;
        counterpercent = pkontratak * 0.01f;
        LvlText.text = "POZIOM - " + plevel.ToString();
        hero.text = hName;
        if (imgnum == 1)
        {
            img1.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 2)
        {
            img2.SetActive(true);
            img1.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 3)
        {
            img3.SetActive(true);
            img2.SetActive(false);
            img1.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 4)
        {
            img4.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
            img1.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 5)
        {
            img5.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img1.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 6)
        {
            img6.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 7)
        {
            img6.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(true);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 8)
        {
            img6.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(true);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 9)
        {
            img6.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(true);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 10)
        {
            img6.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(true);
            img11.SetActive(false);
            img12.SetActive(false);
        }
        if (imgnum == 11)
        {
            img6.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(true);
            img12.SetActive(false);
        }
        if (imgnum == 12)
        {
            img6.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img1.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img10.SetActive(false);
            img11.SetActive(false);
            img12.SetActive(true);
        }
        if (PlayerPrefs.GetInt("odpoczynek") != 1)
        {
            pcurrhealth = PlayerPrefs.GetInt("pendHP");
            pcurrkon = PlayerPrefs.GetInt("pendKON");

        }

            HealthBar.value = pcurrhealth;
            HealthBar.maxValue = pmaxhealth;
            HPText.text = pcurrhealth + "/" + pmaxhealth;
            AdjustCurrentHealth(0);

            KonBar.value = pcurrkon;
            KonBar.maxValue = pmaxkon;
            KonText.text = pcurrkon + "/" + pmaxkon;
            AdjustCurrentCondition(0);
    }
    public void LoadPlayerBattle()
    {
        PlayerSaveScript data1 = PlayerSaving.LoadPlayer1();

    }

    public void AdjustCurrentHealth(int adj)
    {
        pcurrhealth += adj;

        if (pcurrhealth< 1)
        {
            pcurrhealth = 0;
        }

        if (pcurrhealth > pmaxhealth)
        {
            pcurrhealth = pmaxhealth;
        }

        if (pmaxhealth < 1)
        {
            pmaxhealth = 1;
        }
    }
    public void AdjustCurrentCondition(int adj)
    {
        pcurrkon += adj;

        if (pcurrkon < 1)
        {
            pcurrkon = 0;
        }

        if (pcurrkon > pmaxkon)
        {
            pcurrkon = pmaxkon;
        }

        if (pmaxkon < 1)
        {
            pmaxkon = 1;
        }
    }

}
