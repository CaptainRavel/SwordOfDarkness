using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Samouczek : MonoBehaviour
{
    private int number;
    public Image s1;
    public Image s2;
    public Image s3;
    public Image s4;
    public Image s5;
    public Image s6;
    public Image s7;
    public Image s8;
    public Image s9;
    public Image s10;

    public Button dalej;
    public Button wstecz;

    // Start is called before the first frame update
    void Start()
    {
        number = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (number == 1)
        {
            s1.gameObject.SetActive(true);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(false);
            dalej.gameObject.SetActive(true);
        }
        if (number == 2)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(true);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 3)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(true);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 4)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(true);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 5)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(true);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 6)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(true);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 7)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(true);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 8)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(true);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 9)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(true);
            s10.gameObject.SetActive(false);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(true);
        }
        if (number == 10)
        {
            s1.gameObject.SetActive(false);
            s2.gameObject.SetActive(false);
            s3.gameObject.SetActive(false);
            s4.gameObject.SetActive(false);
            s5.gameObject.SetActive(false);
            s6.gameObject.SetActive(false);
            s7.gameObject.SetActive(false);
            s8.gameObject.SetActive(false);
            s9.gameObject.SetActive(false);
            s10.gameObject.SetActive(true);
            wstecz.gameObject.SetActive(true);
            dalej.gameObject.SetActive(false);
        }
    }

    public void Dalej()
    {
        number++;
        if (number >= 11)
        {
            number = 11;
        }
    }

    public void Wstecz()
    {
        number--;
        if (number <= 1)
        {
            number = 1;
        }
    }
}
