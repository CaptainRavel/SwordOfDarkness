using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightScript6 : MonoBehaviour
{
    public Text info;
    public Button turaButton;


    public static int unikiPOgracza;
    public static int gardaPOgracza;
    public static int parowaniePOgracza;
    public static int unikiPOprzeciwnika;
    public static int gardaPOprzeciwnika;
    public static int parowaniePOprzeciwnika;
    public static int rzut1k20;
    private float punikiprocent;
    private float pgardaprocent;
    private float pparowanieprocent;
    private float eunikiprocent;
    private float egardaprocent;
    private float eparowanieprocent;
    private int pszansatrafienia;
    private int eszansatrafienia;
    private int trafienie;
    private int etrafienie;
    private int ptrafienie;
    private string pwylosowanaobrona;
    private string ewylosowanaobrona;
    private int pwylosowanePO;
    private int ewylosowanePO;
    private int minK20;
    private int rodzajobrony;
    private int pobrazenia;
    private int eobrazenia;
    private int tura;
    private float eobrazeniazredukowane;

    static public int patak;
    static public int punik;
    static public int pparowanie;
    static public int pgarda;
    static public int phit;
    private bool wiempu;
    private bool wiempp;
    private bool wiempg;

    static public int eatak;
    static public int eunik;
    static public int eparowanie;
    static public int egarda;
    static public int ehit;
    private bool wiemeu;
    private bool wiemep;
    private bool wiemeg;

    private int koniectury;



    void Start()
    {
    }
    void Update()
    {
    }

    public void StartTimer() //Call this from OnClick
    {
        turaButton.interactable = false;
        Invoke("EndTimer", 3f);
    }

    private void EndTimer()
    {
        turaButton.interactable = true;
    }

    public void NrTury()
    {
        tura++;
        info.text = "<Color=black>" +  "TURA " + tura + " \n" + "</Color>";
        info.text += "<Color=black>" + "_______" + "\n" + "\n" + "</Color>";
        koniectury = 0;

    }

    public void POdczytPO()
    {
        patak = 1;
        unikiPOgracza = DefenseScript.unikiPO;
        gardaPOgracza = DefenseScript.gardaPO;
        parowaniePOgracza = DefenseScript.parowaniePO;
        info.text += "<Color=blue>" + "Wybrane ustawienie obrony: \n" + unikiPOgracza + ", " + gardaPOgracza + ", " + parowaniePOgracza +"\n" + "</color>";
        Debug.Log("Wybrane ustawienie obrony: " + unikiPOgracza + " " + gardaPOgracza + " " + parowaniePOgracza);
        punikiprocent = unikiPOgracza * 10;
        pgardaprocent = gardaPOgracza * 10;
        pparowanieprocent = parowaniePOgracza * 10;
        info.text += "<Color=blue>" + "Procentowy rozkład obron gracza: \n" + punikiprocent + "%, " + pgardaprocent + "%, " + pparowanieprocent + "% \n" + "\n" + "</color>";
        Debug.Log("Procenty gracza do losowania: " + punikiprocent + " " + pgardaprocent + " " + pparowanieprocent);
        if ((int)Random.Range(0, 101) <= punikiprocent)
        {
            wiempu = true;
            wiempp = false;
            wiempg = false;
            info.text += "<Color=blue>" + "Bronisz się UNIKAMI! \n" + "</color>";
            Debug.Log("Bronisz się unikami!");
            pwylosowanaobrona = "Uniki";
            pwylosowanePO = unikiPOgracza;
        }
        else
        {
            if ((int)Random.Range(0, 101) <= pparowanieprocent)
            {
                wiempu = false;
                wiempp = true;
                wiempg = false;
                info.text += "<Color=blue>" + "Bronisz się PAROWANIEM! \n" + "</color>";
                Debug.Log("Bronisz się parowaniem!");
                pwylosowanaobrona = "Parowanie";
                pwylosowanePO = parowaniePOgracza;

            }
            else
            {
                wiempu = false;
                wiempp = false;
                wiempg = true;
                info.text += "<Color=blue>" + "Bronisz się GARDĄ! \n" + "</color>";
                Debug.Log(" Bronisz się gardą!");
                pwylosowanaobrona = "Garda";
                pwylosowanePO = gardaPOgracza;
            }
        }

    }

    public void EOdczytPO()
    {
        unikiPOprzeciwnika = Enemy6Script.e1unikiPO;
        gardaPOprzeciwnika = Enemy6Script.e1gardaPO;
        parowaniePOprzeciwnika = Enemy6Script.e1parowaniePO;
        info.text += "<Color=red>" + "\n" + "Ustawienie obrony przeciwnika: \n" + unikiPOprzeciwnika + ", " + gardaPOprzeciwnika + ", " + parowaniePOprzeciwnika + "\n" + "</color>";
        Debug.Log("Wybrane ustawienie obrony przeciwnika: " + unikiPOprzeciwnika + " " + gardaPOprzeciwnika + " " + parowaniePOprzeciwnika);
        eunikiprocent = unikiPOprzeciwnika * 10;
        egardaprocent = gardaPOprzeciwnika * 10;
        eparowanieprocent = parowaniePOprzeciwnika * 10;
        info.text += "<Color=red>" + "Procentowy rozkład obron przeciwnika: \n" + eunikiprocent + "%, " + egardaprocent + "%, " + eparowanieprocent + "%" + "\n" + "\n" + "</color>";
        Debug.Log("Procenty przeciwnika do losowania: " + eunikiprocent + " " + egardaprocent + " " + eparowanieprocent);
        if ((int)Random.Range(1, 101) <= eunikiprocent)
        {
            wiemeg = false;
            wiemeu = true;
            wiemep = false;
            info.text += "<Color=red>" + "Przeciwnik broni się UNIKAMI! \n" + "</color>";
            Debug.Log("Przeciwnik broni się unikami!");
            ewylosowanaobrona = "Uniki";
            ewylosowanePO = unikiPOprzeciwnika;
        }
        else
        {
            if ((int)Random.Range(1, 101) <= eparowanieprocent)
            {
                wiemeg = false;
                wiemeu = false;
                wiemep = true;
                info.text += "<Color=red>" + "Przeciwnik broni się PAROWANIEM! \n" + "\n" + "</color>";
                Debug.Log("Przeciwnik broni się parowaniem!");
                ewylosowanaobrona = "Parowanie";
                ewylosowanePO = parowaniePOprzeciwnika;
            }
            else
            {
                wiemeg = true;
                wiemeu = false;
                wiemep = false;
                info.text += "<Color=red>" + "Przeciwnik broni się GARDĄ! \n" + "\n" + "</color>";
                Debug.Log("Przeciwnik broni się gardą!");
                ewylosowanaobrona = "Garda";
                ewylosowanePO = gardaPOprzeciwnika;
            }
        }
    }

    public void PRzut1k20()
    {
        rzut1k20 = Random.Range(1, 21);
        info.text += "<Color=blue>" + "Rzut kością 1k20... \n" + "Wylosowałeś " + rzut1k20 + "\n" + "</color>";
        Debug.Log("Wylosowana liczba kostką: " + rzut1k20);

    }

    public void PObliczanieTrafienia()
    {
        pszansatrafienia = rzut1k20 + PModifiScript.trafienie;
        info.text += "<Color=blue>" + "Punkty trafienia gracza: " + rzut1k20 + "+" + PModifiScript.trafienie + "=" + pszansatrafienia + "\n" + "</color>";
        Debug.Log("Punkty trafienia gracza: " + pszansatrafienia);
        if (ewylosowanePO == 0)
        {
            minK20 = 1;
        }
        if (ewylosowanePO == 1)
        {
            minK20 = 3;
        }
        if (ewylosowanePO == 2)
        {
            minK20 = 6;
        }
        if (ewylosowanePO == 3)
        {
            minK20 = 9;
        }
        if (ewylosowanePO == 4)
        {
            minK20 = 12;
        }
        if (ewylosowanePO == 5)
        {
            minK20 = 15;
        }
        Debug.Log("mink20 = " + minK20);
        if (ewylosowanaobrona == "Uniki")
        {
            eszansatrafienia = minK20 + (int)E6ModifiScript.refleks;
            Debug.Log("Wybrany modyfikator refleksu(uniki): " + (int)E6ModifiScript.refleks);
        }

        if (ewylosowanaobrona == "Parowanie")
        {
            eszansatrafienia = minK20;

        }

        if (ewylosowanaobrona == "Garda")
        {

            eszansatrafienia = minK20 + (int)E6ModifiScript.wytrzymalosc;
            Debug.Log("Wybrany modyfikator wytrzymałości(parowanie): " + (int)E6ModifiScript.wytrzymalosc);
        }
        info.text += "<Color=red>" + "Punkty obrony przeciwnika: " +  eszansatrafienia + "\n" + "\n" + "</color>";
        Debug.Log("Punkty obrony przeciwnika: " + eszansatrafienia);

        if (pszansatrafienia >= eszansatrafienia)
        {
            trafienie = 1;
            ehit = 1;
            Debug.Log("Trafiasz!");
        }
        else
        {
            trafienie = 0;
            if (wiemeu == true)
            {
                eunik = 1;
            }
            if (wiemep == true)
            {
                eparowanie = 1;
            }
            if (wiemeg == true)
            {
                egarda = 1;
            }
            Debug.Log("Pudło!");
        }
		        etrafienie = trafienie;
    }

    public void PAtak()
    {
        ptrafienie = trafienie;
        if (ptrafienie == 1)
        {
         
            if (ewylosowanaobrona == "Garda")
            {
                pobrazenia = (int)(PModifiScript.obrazenia - E6ModifiScript.wytrzymalosc);
                if (pobrazenia <= 0)
                {
                    pobrazenia = 0;
                }
                int pobrazeniakrytyczne = pobrazenia * 2;
                int pobrazeniazredukowane = pobrazenia - (int)(pobrazenia * Enemy6Script.e1gardepercent);
                int pobrazeniakrytycznezredukowane = pobrazeniakrytyczne - (int)(pobrazeniakrytyczne * Enemy6Script.e1gardepercent);
                int czykrytyk = 2;
                if (Random.Range(1, 101) <= czykrytyk)
                {
                    float czymakondycje = PlayerBattle.pcurrkon * 0.03f;
                    if (PlayerBattle.pcurrkon >= czymakondycje)
                    {
                        Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniakrytycznezredukowane;
                        PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 15;
                        info.text += "<Color=blue>" + "<b>" + "Wykonujesz atak i zadajesz uderzeniem krytycznym " + pobrazeniakrytycznezredukowane + " pkt obrażeń! (Przeciwnik zredukował gardą" + Enemy6Script.e1garde + "% obrażeń)" + "\n" + "</b>" + "</color>";
                        Debug.Log("Gracz zadaje " + pobrazeniakrytycznezredukowane + " pkt obrażeń! (redukcja gardą)");
                    }
                    else
                    {
                        if (PlayerBattle.pcurrkon <= 5)
                        {
                            Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniazredukowane;
                            PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                            info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz atak i zadajesz " + pobrazeniazredukowane + " pkt obrażeń! (Przeciwnik zredukował gardą " + Enemy6Script.e1garde + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                            Debug.Log("Gracz zadaje " + pobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                        }
                        else
                        {
                            info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                        }
                    }

                }
                else
                {
                    if (PlayerBattle.pcurrkon >= 5)
                    {
                        Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniazredukowane;
                        PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                        info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz atak i zadajesz " + pobrazeniazredukowane + " pkt obrażeń! (Przeciwnik zredukował gardą " + Enemy6Script.e1garde + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                        Debug.Log("Gracz zadaje " + pobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                    }
                    else
                    {
                        info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                    }

                }
            }
            else
            {
                pobrazenia = (int)(PModifiScript.obrazenia - E6ModifiScript.wytrzymalosc);
                if (pobrazenia <= 0)
                {
                    pobrazenia = 0;
                }
                int pobrazeniakrytyczne = pobrazenia * 2;
                int czykrytyk = 2;
                if (Random.Range(1, 101) <= czykrytyk)
                {
                    float czymakondycje = PlayerBattle.pcurrkon * 0.03f;
                    if (PlayerBattle.pcurrkon >= czymakondycje)
                    {
                        Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniakrytyczne;
                        PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 15;
                        info.text += "<Color=blue>" + "<b>" + "Wykonujesz atak i zadajesz uderzeniem krytycznym " + pobrazeniakrytyczne + " pkt obrażeń!" + "\n" + "</b>" + "</color>";
                        Debug.Log("Gracz zadaje " + pobrazeniakrytyczne + " pkt obrażeń!");
                    }
                    else
                    {
                        if (PlayerBattle.pcurrkon >= 5)
                        {
                            Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazenia;
                            PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                            info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz atak i zadajesz " + pobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";
                            Debug.Log("Gracz zadaje " + pobrazenia + " pkt obrażeń z kontrataku!");
                        }
                        else
                        {
                            info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                        }
                    }

                }
                else
                {
                    if (PlayerBattle.pcurrkon >= 5)
                    {
                        Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazenia;
                        PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                        info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz atak i zadajesz " + pobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";
                        Debug.Log("Gracz zadaje " + pobrazenia + " pkt obrażeń z kontrataku!");
                    }
                    else
                    {
                        info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                    }
                }
            }
        }
        else
        {
            info.text += "<Color=blue>" + "<b>" + "Nie trafiasz w przeciwnika!" + "\n" + "</b>" + "</color>";
            Debug.Log("Gracz pudłuje!");
        }
    }

    public void ERzut1k20()
    {

        rzut1k20 = Random.Range(1, 21);
        info.text += "<Color=red>" + "\n" + "Rzut kością 1k20... \n" + "Przeciwnik wylosował " + rzut1k20 + "\n" + "</color>";
        Debug.Log("Wylosowana liczba kostką: " + rzut1k20);
    }

    public void EObliczanieTrafienia()
    {
        eatak = 1;
        eszansatrafienia = rzut1k20 + E6ModifiScript.trafienie;
        info.text += "<Color=red>" + "Punkty trafienia przeciwnika: " + rzut1k20 + "+" + E6ModifiScript.trafienie + "=" + eszansatrafienia + "\n" + "</color>";
        Debug.Log("Punkty trafienia przeciwnika: " + eszansatrafienia);
        if (pwylosowanePO == 0)
        {
            minK20 = 1;
        }
        if (pwylosowanePO == 1)
        {
            minK20 = 3;
        }
        if (pwylosowanePO == 2)
        {
            minK20 = 6;
        }
        if (pwylosowanePO == 3)
        {
            minK20 = 9;
        }
        if (pwylosowanePO == 4)
        {
            minK20 = 12;
        }
        if (pwylosowanePO == 5)
        {
            minK20 = 15;
        }
        Debug.Log("mink20 = " + minK20);
        if (pwylosowanaobrona == "Uniki")
        {
            pszansatrafienia = minK20 + (int)PModifiScript.refleks;
            Debug.Log("Wybrany modyfikator refleksu(uniki): " + (int)PModifiScript.refleks);
        }

        if (pwylosowanaobrona == "Parowanie")
        {

            pszansatrafienia = minK20;
        }

        if (pwylosowanaobrona == "Garda")
        {
            pszansatrafienia = minK20 + (int)PModifiScript.wytrzymalosc;
            Debug.Log("Wybrany modyfikator wytrzymałości(parowanie): " + (int)PModifiScript.wytrzymalosc);
        }
        info.text += "<Color=blue>" + "Twoje punkty oborny: " + pszansatrafienia + "\n" + "\n" + "</color>";
        Debug.Log("Punkty obrony gracza: " + pszansatrafienia);

        if (eszansatrafienia >= pszansatrafienia)
        {
            trafienie = 1;

            Debug.Log("Przeciwnik trafia!");
        }
        else
        {
            trafienie = 0;
            if (wiempu == true)
            {
                punik = 1;
            }
            if (wiempp == true)
            {
                pparowanie = 1;
            }
            if (wiempg == true)
            {
                pgarda = 1;
            }
            Debug.Log("Przeciwnik pudłuje!");
        }
    }

     public void EAtak()
    {
        etrafienie = trafienie;
        if (etrafienie == 1)
        {
            phit = 1;
            if (pwylosowanaobrona == "Garda")
            {
                eobrazenia = (int)(E6ModifiScript.obrazenia - PModifiScript.wytrzymalosc);
                if (eobrazenia <= 0)
                {
                    eobrazenia = 0;
                }
                int eobrazeniakrytyczne = eobrazenia * 2;
                int eobrazeniazredukowane = eobrazenia - (int)(eobrazenia * PlayerBattle.gardepercent);
                int eobrazeniakrytycznezredukowane = eobrazeniakrytyczne - (int)(eobrazeniakrytyczne * PlayerBattle.gardepercent);
                int czykrytyk = 2;
                if (Random.Range(1, 101) <= czykrytyk)
                {
                    float czyemakondycje;
                    czyemakondycje = Enemy6Script.e1currentKon * 0.03f;
                    if (Enemy6Script.e1currentKon >= czyemakondycje)
                    {
                        PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniakrytycznezredukowane;
                        Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 15;
                        info.text += "<Color=blue>" + "<b>" + "Wróg wykonuje atak i zadaje ci uderzeniem krytycznym " + eobrazeniakrytycznezredukowane + " pkt obrażeń! (Gracz zredukował gardą" + PlayerBattle.pgarda + "% obrażeń)" + "\n" + "</b>" + "</color>";
                        Debug.Log("Gracz zadaje " + eobrazeniakrytycznezredukowane + " pkt obrażeń! (redukcja gardą)");
                    }
                    else
                    {
                        if (Enemy6Script.e1currentKon >= 5)
                        {
                            PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniazredukowane;
                            Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                            info.text += "<Color=red>" + "<b>" + "Wróg wykonuje atak i zadaje ci " + eobrazeniazredukowane + " pkt obrażeń! (Gracz zredukował gardą " + PlayerBattle.pgarda + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                            Debug.Log("Przeciwnik zadaje " + eobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                        }
                        else
                        {
                            info.text += "<Color=red>" + "<b>" + "Wróg ma zbyt mało kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                        }
                    }
                }
                else
                {
                    if (Enemy6Script.e1currentKon >= 5)
                    {
                        PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniazredukowane;
                        Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                        info.text += "<Color=red>" + "<b>" + "Wróg wykonuje atak i zadaje ci " + eobrazeniazredukowane + " pkt obrażeń! (Gracz zredukował gardą " + PlayerBattle.pgarda + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                        Debug.Log("Przeciwnik zadaje " + eobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                    }
                    else
                    {
                        info.text += "<Color=red>" + "<b>" + "Wróg ma zbyt mało kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                    }
                }
            }
            else
            {
                eobrazenia = (int)(E6ModifiScript.obrazenia - PModifiScript.wytrzymalosc);
                if (eobrazenia <= 0)
                {
                    eobrazenia = 0;
                }
                int eobrazeniakrytyczne = eobrazenia * 2;
                int czykrytyk = 2;
                if (Random.Range(1, 101) <= czykrytyk)
                {
                    float czymakondycje = Enemy6Script.e1currentKon * 0.03f;
                    if (Enemy6Script.e1currentKon >= czymakondycje)
                    {
                        PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniakrytyczne;
                        Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 15;
                        info.text += "<Color=red>" + "<b>" + "Wróg wykonuje atak zadaje uderzeniem krytycznym " + eobrazeniakrytyczne + " pkt obrażeń!" + "\n" + "</b>" + "</color>";
                    }
                    else
                    {
                        if (Enemy6Script.e1currentKon >= 5)
                        {
                            PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazenia;
                            Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                            info.text += "<Color=red>" + "<b>" + "\n" + "Wróg wykonuje atak i zadaje " + eobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";
                        }
                        else
                        {
                            info.text += "<Color=red>" + "<b>" + "\n" + "Przeciwnik  nie ma wystarczojąco kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                        }
                    }

                }
                else
                {
                    if (Enemy6Script.e1currentKon >= 5)
                    {
                        PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazenia;
                        Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                        info.text += "<Color=red>" + "<b>" + "\n" + "Wróg wykonuje atak i zadaje " + eobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";

                    }
                    else
                    {
                        info.text += "<Color=red>" + "<b>" + "\n" + "Przeciwnik  nie ma wystarczojąco kondycji by wykonać atak" + "\n" + "</b>" + "</color>";
                    }
                }
            }
        }
        else
        {
            info.text += "<Color=red>" + "<b>" + "Wróg Cię nie trafia!" + "\n" + "</b>" + "</color>";
            Debug.Log("Gracz pudłuje!");
        }
        
    }

    public void PKontratak()
    {
        if (ptrafienie == 1)
        {
            if (pwylosowanaobrona == "Parowanie")
            {
                if ((int)Random.Range(1, 101) <= PlayerBattle.pkontratak)
                {
                    if (ewylosowanaobrona == "Garda")
                    {
                        pobrazenia = (int)(PModifiScript.obrazenia - E6ModifiScript.wytrzymalosc);
                        if (pobrazenia <= 0)
                        {
                            pobrazenia = 0;
                        }
                        int pobrazeniakrytyczne = pobrazenia * 2;
                        int pobrazeniazredukowane = pobrazenia - (int)(pobrazenia * Enemy6Script.e1gardepercent);
                        int pobrazeniakrytycznezredukowane = pobrazeniakrytyczne - (int)(pobrazeniakrytyczne * Enemy6Script.e1gardepercent);
                        int czykrytyk = 2;
                        if (Random.Range(1, 101) <= czykrytyk)
                        {
                            float czymakondycje = PlayerBattle.pcurrkon * 0.03f;
                            if (PlayerBattle.pcurrkon >= czymakondycje)
                            {
                                Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniakrytycznezredukowane;
                                PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 15;
                                info.text += "<Color=blue>" + "<b>" + "Wykonujesz kontratak i zadajesz uderzeniem krytycznym " + pobrazeniakrytycznezredukowane + " pkt obrażeń! (Przeciwnik zredukował gardą" + Enemy6Script.e1garde + "% obrażeń)" + "\n" + "</b>" + "</color>";
                                Debug.Log("Gracz zadaje " + pobrazeniakrytycznezredukowane + " pkt obrażeń! (redukcja gardą)");
                            }
                            else
                            {
                                if (PlayerBattle.pcurrkon >= 5)
                                {
                                    Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniazredukowane;
                                    PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                                    info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz kontratak i zadajesz " + pobrazeniazredukowane + " pkt obrażeń! (Przeciwnik zredukował gardą " + Enemy6Script.e1garde + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                                    Debug.Log("Gracz zadaje " + pobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                                }
                                else
                                {
                                    info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                                }
                            }

                        }
                        else
                        {
                            if (PlayerBattle.pcurrkon >= 5)
                            {
                                Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniazredukowane;
                                PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                                info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz kontratak i zadajesz " + pobrazeniazredukowane + " pkt obrażeń! (Przeciwnik zredukował gardą " + Enemy6Script.e1garde + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                                Debug.Log("Gracz zadaje " + pobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                            }
                            else
                            {
                                info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                            }

                        }
                    }
                    else
                    {
                        pobrazenia = (int)(PModifiScript.obrazenia - E6ModifiScript.wytrzymalosc);
                        if (pobrazenia <= 0)
                        {
                            pobrazenia = 0;
                        }
                        int pobrazeniakrytyczne = pobrazenia * 2;
                        int czykrytyk = 2;
                        if (Random.Range(1, 101) <= czykrytyk)
                        {
                            float czymakondycje = PlayerBattle.pcurrkon * 0.03f;
                            if (PlayerBattle.pcurrkon >= czymakondycje)
                            {
                                Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazeniakrytyczne;
                                PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 15;
                                info.text += "<Color=blue>" + "<b>" + "Wykonujesz kontratak i zadajesz uderzeniem krytycznym " + pobrazeniakrytyczne + " pkt obrażeń!" + "\n" + "</b>" + "</color>";
                                Debug.Log("Gracz zadaje " + pobrazeniakrytyczne + " pkt obrażeń!");
                            }
                            else
                            {
                                if (PlayerBattle.pcurrkon >= 5)
                                {
                                    Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazenia;
                                    PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                                    info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz kontratak i zadajesz " + pobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";
                                    Debug.Log("Gracz zadaje " + pobrazenia + " pkt obrażeń z kontrataku!");
                                }
                                else
                                {
                                    info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                                }
                            }

                        }
                        else
                        {
                            if (PlayerBattle.pcurrkon >= 5)
                            {
                                Enemy6Script.e1currentHealth = Enemy6Script.e1currentHealth - pobrazenia;
                                PlayerBattle.pcurrkon = PlayerBattle.pcurrkon - 5;
                                info.text += "<Color=blue>" + "<b>" + "\n" + "Wykonujesz kontratak i zadajesz " + pobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";
                                Debug.Log("Gracz zadaje " + pobrazenia + " pkt obrażeń z kontrataku!");
                            }
                            else
                            {
                                info.text += "<Color=blue>" + "<b>" + "\n" + "Nie masz wystarczojąco kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                            }
                        }
                    }
                }
                else
                {
                    info.text += "<Color=blue>" + "<b>" + "\n" + "Kontratak gracza nieudany" + "\n" + "\n" + "</b>" + "</color>";
                    Debug.Log("Kontratak gracza nieudany");
                }
            }
        }
        else
        {

        }
    }

    public void EKontratak()
    {
        if (etrafienie == 1)
        {
            if (ewylosowanaobrona == "Parowanie")
            {
                if ((int)Random.Range(1, 101) <= Enemy6Script.e1counter)
                {
                    if (pwylosowanaobrona == "Garda")
                    {
                        eobrazenia = (int)(E6ModifiScript.obrazenia - PModifiScript.wytrzymalosc);
                        if (eobrazenia <= 0)
                        {
                            eobrazenia = 0;
                        }
                        int eobrazeniakrytyczne = eobrazenia * 2;
                        int eobrazeniazredukowane = eobrazenia - (int)(eobrazenia * PlayerBattle.gardepercent);
                        int eobrazeniakrytycznezredukowane = eobrazeniakrytyczne - (int)(eobrazeniakrytyczne * PlayerBattle.gardepercent);
                        int czykrytyk = 2;
                        if (Random.Range(1, 101) <= czykrytyk)
                        {
                            float czyemakondycje;
                            czyemakondycje = Enemy6Script.e1currentKon * 0.03f;
                            if (Enemy6Script.e1currentKon >= czyemakondycje)
                            {
                                PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniakrytycznezredukowane;
                                Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 15;
                                info.text += "<Color=blue>" + "<b>" + "Wróg wykonuje kontratak i zadaje ci uderzeniem krytycznym " + eobrazeniakrytycznezredukowane + " pkt obrażeń! (Gracz zredukował gardą" + PlayerBattle.pgarda + "% obrażeń)" + "\n" + "</b>" + "</color>";
                                Debug.Log("Gracz zadaje " + eobrazeniakrytycznezredukowane + " pkt obrażeń! (redukcja gardą)");
                            }
                            else
                            {
                                if (Enemy6Script.e1currentKon >= 5)
                                {
                                    PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniazredukowane;
                                    Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                                    info.text += "<Color=red>" + "<b>" + "Wróg wykonuje kontratak i zadaje ci " + eobrazeniazredukowane + " pkt obrażeń! (Gracz zredukował gardą " + PlayerBattle.pgarda + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                                    Debug.Log("Przeciwnik zadaje " + eobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                                }
                                else
                                {
                                    info.text += "<Color=red>" + "<b>" + "Wróg ma zbyt mało kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                                }
                            }
                        }
                        else
                        {
                            if (Enemy6Script.e1currentKon >= 5)
                            {
                                PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniazredukowane;
                                Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                                info.text += "<Color=red>" + "<b>" + "Wróg wykonuje kontratak i zadaje ci " + eobrazeniazredukowane + " pkt obrażeń! (Gracz zredukował gardą " + PlayerBattle.pgarda + "% obrażeń)" + "\n" + "\n" + "</b>" + "</color>";
                                Debug.Log("Przeciwnik zadaje " + eobrazeniazredukowane + " pkt obrażeń z kontrataku! (redukcja gardą)");
                            }
                            else
                            {
                                info.text += "<Color=red>" + "<b>" + "Wróg ma zbyt mało kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                            }
                        }
                    }
                    else
                    {
                        eobrazenia = (int)(E6ModifiScript.obrazenia - PModifiScript.wytrzymalosc);
                        if (eobrazenia <= 0)
                        {
                            eobrazenia = 0;
                        }
                        int eobrazeniakrytyczne = eobrazenia * 2;
                        int czykrytyk = 2;
                        if (Random.Range(1, 101) <= czykrytyk)
                        {
                            float czyemakondycje;
                            czyemakondycje = Enemy6Script.e1currentKon * 0.03f;
                            if (Enemy6Script.e1currentKon >= czyemakondycje)
                            {
                                PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazeniakrytyczne;
                                Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 15;
                                info.text += "<Color=blue>" + "<b>" + "Wróg wykonuje kontratak i zadaje ci uderzeniem krytycznym " + eobrazeniakrytyczne + " pkt obrażeń!" + "\n" + "</b>" + "</color>";
                                Debug.Log("Gracz zadaje " + eobrazeniakrytyczne + " pkt obrażeń!");
                            }
                            else
                            {
                                if (Enemy6Script.e1currentKon >= 5)
                                {
                                    PlayerBattle.pcurrhealth = PlayerBattle.pcurrhealth - eobrazenia;
                                    Enemy6Script.e1currentKon = Enemy6Script.e1currentKon - 5;
                                    info.text += "<Color=red>" + "<b>" + "Wróg wykonuje kontratak i zadaje ci " + eobrazenia + " pkt obrażeń!" + "\n" + "\n" + "</b>" + "</color>";
                                    Debug.Log("Przeciwnik zadaje " + eobrazenia + " pkt obrażeń z kontrataku!");
                                }
                                else
                                {
                                    info.text += "<Color=red>" + "<b>" + "Wróg ma zbyt mało kondycji by wykonać kontratak" + "\n" + "</b>" + "</color>";
                                }
                            }
                        }
                    }
                }
                else
                {
                    info.text += "<Color=red>" + "<b>" + "\n" + "Kotratak przeciwnika nieudany" + "\n" + "\n" + "</b>" + "</color>";
                    Debug.Log("Kontratak przeciwnika nieudany");
                }
            }
        }
        else
        {
        }
    }
    public void RegeneracjaKondycji()
    {
        PlayerBattle.pcurrkon = PlayerBattle.pcurrkon + (int)PModifiScript.kondycjareg;
        Enemy6Script.e1currentKon = Enemy6Script.e1currentKon + E6ModifiScript.conditionreg;
        PlayerPrefs.SetInt("pendHP", PlayerBattle.pcurrhealth);
        PlayerPrefs.SetInt("pendKON", PlayerBattle.pcurrkon);
        PlayerPrefs.Save();

    }

}
