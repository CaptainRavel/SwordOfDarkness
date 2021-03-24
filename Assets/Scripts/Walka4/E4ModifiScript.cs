using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4ModifiScript : MonoBehaviour
{
    public static float obrazenia;
    public static int trafienie;
    public static float wytrzymalosc;
    public static float refleks;
    public static float conditionreg;



    void Start()
    {
    }

    void Update()
    {
        obrazenia = (int)(Enemy4Script.e1baseattack + Random.Range(2,13) + (Enemy4Script.e1patb * 0.1f));
        trafienie = (int)(Enemy4Script.e1patb * 0.1f);
        wytrzymalosc = (int)(Enemy4Script.e1satb * 0.1f);
        refleks = (int)(Enemy4Script.e1satb * 0.1f);
        conditionreg = Enemy4Script.e1vit * Enemy4Script.e1regeneracjakondycji;
    }

    public void Logi()
    {
        Debug.Log("Atrybuty: " + (int)Enemy4Script.e1patb);
        Debug.Log("Cechy: " + (int)Enemy4Script.e1satb);
        Debug.Log("Zdrowie: " + (int)Enemy4Script.e1vit);
        Debug.Log("Ilość obrażeń: " + obrazenia);
        Debug.Log("Modyfikator trafień: " + trafienie);
        Debug.Log("Modyfikator wytrzymałości: " + wytrzymalosc);
        Debug.Log("Modyfikator refleksu: " + refleks);
    }
}
