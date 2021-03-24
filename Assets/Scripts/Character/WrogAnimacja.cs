using UnityEngine;

public class WrogAnimacja : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript.eunik = 0;
        }
        if (FightScript.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript.eparowanie = 0;
        }
        if (FightScript.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript.egarda = 0;
        }
        if (FightScript.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript.ehit = 0;
        }
        if (FightScript.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript.eatak = 0;
        }
    }
}
