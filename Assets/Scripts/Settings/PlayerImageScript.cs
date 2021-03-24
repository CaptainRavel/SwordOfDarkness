using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerImageScript : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    static public int error;
   

    public void Start()
    {
  
    }

    public void Update()
    {
        
        if (p1.activeSelf == false && p2.activeSelf == false && p3.activeSelf == false && p4.activeSelf == false && p5.activeSelf == false && p6.activeSelf == false)
        {
            error = 1;
        }
        else
        {
            error = 0;
        }
    
    }

    public void ResetImages()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
    }
    public void Image1Choice()
    {
        p1.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
    }
    public void Image2Choice()
    {
        p1.SetActive(false);
        p2.SetActive(true);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
    }
    public void Image3Choice()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(true);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
    }
    public void Image4Choice()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(true);
        p5.SetActive(false);
        p6.SetActive(false);
    }
    public void Image5Choice()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(true);
        p6.SetActive(false);
    }
    public void Image6Choice()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(true);
    }
}
