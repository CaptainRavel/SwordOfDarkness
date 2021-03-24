using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy5Script : MonoBehaviour
{
    static public int e1patb;
    static public int e1satb;
    static public int e1vit;
    static public int e1garde;
    static public float e1gardepercent;
    static public float e1counterpercent;
    static public int e1counter;
    static public int e1level;
    static public int e1baseattack;
    static public float e1obr;
    static public float e1maxHealth;
    static public float e1currentHealth;
    static public float e1maxKon;
    static public float e1currentKon;
    static public int e1unikiPO = 5;
    static public int e1gardaPO= 1;
    static public int e1parowaniePO = 4;
    public static float e1regeneracjakondycji;

    private string imieWroga;
    public Text WrogName;

    public Slider e1HPslider;
    public Text e1HPtext;
    public Slider e1Konslider;
    public Text e1Kontext;
    void Start()
    {
        imieWroga = "Ork";
        WrogName.text = imieWroga;

        e1patb = Random.Range(50, 56);
        e1satb = Random.Range(35, 41);
        e1vit = Random.Range(16, 20)*10;
        e1garde = 50;
        e1gardepercent = e1garde * 0.01f;
        e1counter = 45;
        e1counterpercent = e1counter * 0.01f;
        e1level = 5;
        e1baseattack = 1;
        e1obr = E5ModifiScript.obrazenia;
        e1maxHealth = e1vit;
        e1currentHealth = e1vit;
        e1maxKon = e1vit;
        e1currentKon = e1vit;
        e1regeneracjakondycji = 0.01f;
    }

    void Update()
    {
        e1maxHealth = e1vit;
        int e1currHealth;
        e1currHealth = (int)e1currentHealth;
        e1HPslider.value = e1currHealth;
        e1HPslider.maxValue = e1maxHealth;
        e1HPtext.text = e1currentHealth + "/" + e1maxHealth;
        AdjustCurrentHealth(0);

        e1maxKon = e1vit;
        int e1currKon;
        e1currKon = (int)e1currentKon;
        e1Konslider.value = e1currKon;
        e1Konslider.maxValue = e1maxKon;
        e1Kontext.text = e1currKon + "/" + e1maxKon;
        AdjustCurrentCondition(0);

    }
    public void AdjustCurrentHealth(int adj)
    {
        e1currentHealth += adj;

        if (e1currentHealth < 1)
        {
            e1currentHealth = 0;
        }

        if (e1currentHealth > e1maxHealth)
        {
            e1currentHealth = e1maxHealth;
        }

        if (e1maxHealth < 1)
        {
            e1maxHealth = 1;
        }
    }
    public void AdjustCurrentCondition(int adj)
    {
        e1currentKon += adj;

        if (e1currentKon < 1)
        {
            e1currentKon = 0;
        }

        if (e1currentKon > e1maxKon)
        {
            e1currentKon = e1maxKon;
        }

        if (e1maxKon < 1)
        {
            e1maxKon = 1;
        }
    }
}
