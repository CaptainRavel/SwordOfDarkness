using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public GameObject optionpanel;
    public GameObject statpanel;
    public GameObject invpanel;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {

    }
    void Update()
    {
    }

    public void OptPanel()
    {
        if (optionpanel.activeSelf)
        {
            optionpanel.SetActive(false);

        }
        else
        {
            optionpanel.SetActive(true);
            statpanel.SetActive(false);
            invpanel.SetActive(false);
        }
    }
    public void StatPanel()
    {
        if (statpanel.activeSelf)
        {
            statpanel.SetActive(false);

        }
        else
        {
            statpanel.SetActive(true);
            optionpanel.SetActive(false);
            invpanel.SetActive(false);
        }
    }
    public void InvPanel()
    {
        if (invpanel.activeSelf)
        {
            invpanel.SetActive(false);

        }
        else
        {
            invpanel.SetActive(true);
            statpanel.SetActive(false);
            optionpanel.SetActive(false);
        }
    }
}