using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HeroGenerationUIScript : MonoBehaviour
{
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
    private Button pimg1;
    [SerializeField]
    private Button pimg2;
    [SerializeField]
    private Button pimg3;
    [SerializeField]
    private Button pimg4;
    [SerializeField]
    private Button pimg5;
    [SerializeField]
    private Button pimg6;
    [SerializeField]
    private Button pimg7;
    [SerializeField]
    private Button pimg8;
    [SerializeField]
    private Button pimg9;
    [SerializeField]
    private Button pimg10;
    [SerializeField]
    private Button pimg11;
    [SerializeField]
    private Button pimg12;
    [SerializeField]
    private Button kButton;
    [SerializeField]
    private Button mButton;
    [SerializeField]
    private Text hero;
    [SerializeField]
    private InputField heroName;
    [SerializeField]
    private Text warnings;
    [SerializeField]
    private GameObject warningsWindow;
    [SerializeField]
    private GameObject CaHWindow;
    static public int imgnum;
    static public string hName;
    static public int hPlec = 0;

    void Start()
    {
        heroName.characterLimit = 20;

        if (PlayerPrefs.GetInt("ContinueGame") == 1)
        {
            PlayerSaveScript data2 = PlayerSaving.LoadPlayer2();
            imgnum = data2.pImageNumber;
            hName = data2.pName;
        }
    }

    void Update()
    {
        
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
    }

    public void SavePlayer2()
    {
        PlayerSaving.SavePlayer2(this);
    }

    public void LoadPlayer2()
    {
        PlayerSaveScript data2 = PlayerSaving.LoadPlayer2();
        imgnum = data2.pImageNumber;
        hName = data2.pName;
    }
    public int ImageNumber
    {
        get { return imgnum; }
        set { imgnum = value; }
    }

    public void HeroName()
    {
        if (string.IsNullOrEmpty(heroName.text))
        {
            hName = "Bohater";
        }
        else
        {
            hName = heroName.text;
        }
    }
    public string HeroString
    {
        get { return heroName.text; }
        set { heroName.text = value; }
    }

    public void SetImage(int imageNumber)
    {
        imgnum = imageNumber;

    }

    public void PlecK()
    {
        hPlec = 1;
        pimg1.gameObject.SetActive(false);
        pimg2.gameObject.SetActive(false);
        pimg3.gameObject.SetActive(false);
        pimg4.gameObject.SetActive(false);
        pimg5.gameObject.SetActive(false);
        pimg6.gameObject.SetActive(false);

      

        pimg7.gameObject.SetActive(true);
        pimg8.gameObject.SetActive(true);
        pimg9.gameObject.SetActive(true);
        pimg10.gameObject.SetActive(true);
        pimg11.gameObject.SetActive(true);
        pimg12.gameObject.SetActive(true);


    }

    public void PlecM()
    {
        hPlec = 2;
        pimg7.gameObject.SetActive(false);
        pimg8.gameObject.SetActive(false);
        pimg9.gameObject.SetActive(false);
        pimg10.gameObject.SetActive(false);
        pimg11.gameObject.SetActive(false);
        pimg12.gameObject.SetActive(false);

     

        pimg1.gameObject.SetActive(true);
        pimg2.gameObject.SetActive(true);
        pimg3.gameObject.SetActive(true);
        pimg4.gameObject.SetActive(true);
        pimg5.gameObject.SetActive(true);
        pimg6.gameObject.SetActive(true);
    }

    public void CheckHero()
    {
        if (heroName.text == "")
        {
            warningsWindow.SetActive(true);
            warnings.text = "Musisz wpisać imię przed rozpoczęciem gry!";
        }
        else if (hPlec == 0)
        {
            warningsWindow.SetActive(true);
            warnings.text = "Musisz wybrać płeć bohatera przed rozpoczęciem gry!";
        }
        else if (PlayerImageScript.error == 1)
        {
            warningsWindow.SetActive(true);
            warnings.text = "Musisz wybrać portret dla bohatera przed rozpoczęciem gry!";
        }
        else
        {
            CaHWindow.SetActive(false);
        }
    }

}
