using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameScript : MonoBehaviour
{
    public void DoExitGame()
    {
        Debug.Log("Wyjście z gry");
        Application.Quit();
    }
}
