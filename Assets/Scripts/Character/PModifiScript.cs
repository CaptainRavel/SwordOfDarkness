using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PModifiScript : MonoBehaviour
{
    public static float obrazenia;
    public static int trafienie;
    public static float wytrzymalosc;
    public static float refleks;
    public static float kondycjareg;
    private float min;
    private float max;




    void Start()
    {
    }

    void Update()
    {
        obrazenia = Random.Range(PlayerBattle.pobrmin, PlayerBattle.pobrmax +1) + (PlayerBattle.psiła * 0.1f);
        trafienie = (int)(PlayerBattle.pzrecznosc * 0.1f);
        wytrzymalosc = (int)(PlayerBattle.pwytrzymalosc * 0.1f);
        refleks = (int)(PlayerBattle.prefleks * 0.1f);
        kondycjareg = PlayerBattle.pmaxkon * PlayerBattle.pregeneracjakondycji;
        Debug.Log("obrmin = " + PlayerBattle.pobrmin + ", obrmax = " + PlayerBattle.pobrmax + ", wylosowane obrazenia: " + (Random.Range(PlayerBattle.pobrmin, PlayerBattle.pobrmax)));
    }
}
