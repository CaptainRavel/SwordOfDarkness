using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DefenseScript : MonoBehaviour
{

    private int punktyAkcji;
    private int pA;
    private int wolnePA;
    private int unikiPkt;
    private int gardaPkt;
    private int parowaniePkt;
    private int pozostalePA;
    private int stalePA;
    private int uzytePA;
    public static int unikiPO;
    public static int gardaPO;
    public static int parowaniePO;
    public Text UzytePA;
    public Text WolnePA;

    public Dropdown Uniki;
    public Dropdown Garda;
    public Dropdown Parowanie;

    void Start()
    {
        stalePA = 10;
        punktyAkcji = 10;
        unikiPkt = 0;
        gardaPkt = 0;
        parowaniePkt = 0;


}
    void Update()
    {
        unikiPO = Uniki.value;
        gardaPO = Garda.value;
        parowaniePO = Parowanie.value;
        uzytePA = unikiPkt + gardaPkt + parowaniePkt;
        UzytePA.text = "Wykorzystane punkty obrony: " + uzytePA.ToString();
        wolnePA = stalePA - uzytePA;
        WolnePA.text = "Pozostałe punkty obrony: " + wolnePA.ToString();

    }

    public void UnikiPA()
    {
        punktyAkcji = stalePA;
        if (Uniki.value == 0)
        {
            unikiPkt = stalePA - 10;
        }
        if (Uniki.value == 1)
        {
            if (gardaPkt + parowaniePkt <= 9)
            {
                unikiPkt = stalePA - 9;
            }
            else
            {
                Uniki.value = 0;
            }
        }
        if (Uniki.value == 2)
        {
            if (gardaPkt + parowaniePkt <= 8 )
            {
                unikiPkt = stalePA - 8;
            }
            else
            {
                Uniki.value = 1;
            }

        }
        if (Uniki.value == 3)
        {
            if (gardaPkt + parowaniePkt <= 7)
            {
                unikiPkt = stalePA - 7;
            }
            else
            {
                Uniki.value = 2;
            }
        }
        if (Uniki.value == 4)
        {
            if (gardaPkt + parowaniePkt <= 6)
            {
                unikiPkt = stalePA - 6;
            }
            else
            {
                Uniki.value = 3;
            }
        }
        if (Uniki.value == 5)
        {
            if (gardaPkt + parowaniePkt <= 5)
            {
                unikiPkt = stalePA - 5;
            }
            else
            {
                Uniki.value = 4;
            }
        }

    }
    
    public void GardaPA()
    {
        punktyAkcji = stalePA;
        if (Garda.value == 0)
        {
            gardaPkt = stalePA - 10;
        }
        if (Garda.value == 1)
        {
            if (unikiPkt + parowaniePkt <= 9 )
            {
                gardaPkt = stalePA - 9;
            }
            else
            {
                Garda.value = 0;
            }
        }
        if (Garda.value == 2)
        {
            if (unikiPkt + parowaniePkt <= 8)
            {
                gardaPkt = stalePA - 8;
            }
            else
            {
                Garda.value = 1;
            }
        }
        if (Garda.value == 3)
        {
            if (unikiPkt + parowaniePkt <= 7)
            {
                gardaPkt = stalePA - 7;
            }
            else
            {
                Garda.value = 2;
            }
        }
        if (Garda.value == 4)
        {
            if (unikiPkt + parowaniePkt <= 6)
            {
                gardaPkt = stalePA - 6;
            }
            else
            {
                Garda.value = 3;
            }
        }
        if (Garda.value == 5)
        {
            if (unikiPkt + parowaniePkt <= 5)
            {
                gardaPkt = stalePA - 5;
            }
            else
            {
                Garda.value = 4;
            }
        }

    }

    public void ParowaniePA()
    {
        punktyAkcji = stalePA;
        if (Parowanie.value == 0)
        {
            parowaniePkt = stalePA - 10;
        }
        if (Parowanie.value == 1)
        {
            if (unikiPkt + gardaPkt <= 9)
            {
                parowaniePkt = stalePA - 9;
            }
            else
            {
                Parowanie.value = 0;
            }
        }
        if (Parowanie.value == 2)
        {
            if (unikiPkt + gardaPkt <= 8)
            {
                parowaniePkt = stalePA - 8;
            }
            else
            {
                Parowanie.value = 1;
            }
        }
        if (Parowanie.value == 3)
        {
            if (unikiPkt + gardaPkt <= 7)
            {
                parowaniePkt = stalePA - 7;
            }
            else
            {
                Parowanie.value = 2;
            }
        }
        if (Parowanie.value == 4)
        {
            if (unikiPkt + gardaPkt <= 6)
            {
                parowaniePkt = stalePA - 6;
            }
            else
            {
                Parowanie.value = 3;
            }
        }
        if (Parowanie.value == 5)
        {
            if (unikiPkt + gardaPkt <= 5)
            {
                parowaniePkt = stalePA - 5;
            }
            else
            {
                Parowanie.value = 4;
            }
        }

    }
}
