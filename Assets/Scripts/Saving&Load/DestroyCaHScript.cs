using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCaHScript : MonoBehaviour
{
    public GameObject CaHPanel;
    private int isON;
    void Start()
    {
        isON = PlayerPrefs.GetInt("CaHON");
        if (isON == 1)
        {
            CaHPanel.SetActive(false);
        }
        else
            CaHPanel.SetActive(true);
    }

}
