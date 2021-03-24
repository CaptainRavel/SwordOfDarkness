using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatPanel : MonoBehaviour
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
    private Text hero;
    [SerializeField]
    private Text heroPlec;

    private string hname;
    private int himg;
    private int hplec;

    void Start()
    {
    }

    void Update()
    {
        hplec = HeroGenerationUIScript.hPlec;
        hname = HeroGenerationUIScript.hName;
        himg = HeroGenerationUIScript.imgnum;

        hero.text = hname;

        if (hplec == 1)
        {
            heroPlec.text = "KOBIETA";
        }
        if (hplec == 2)
        {
            heroPlec.text = "MĘŻCZYZNA";
        }


        if (himg == 1)
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
        if (himg == 2)
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
        if (himg == 3)
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
        if (himg == 4)
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
        if (himg == 5)
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
        if (himg == 6)
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
        if (himg == 7)
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
        if (himg == 8)
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
        if (himg == 9)
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
        if (himg == 10)
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
        if (himg == 11)
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
        if (himg == 12)
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
}

