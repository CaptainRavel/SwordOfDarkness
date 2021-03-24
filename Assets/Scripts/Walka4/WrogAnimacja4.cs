using UnityEngine;

public class WrogAnimacja4 : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript4.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript4.eunik = 0;
        }
        if (FightScript4.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript4.eparowanie = 0;
        }
        if (FightScript4.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript4.egarda = 0;
        }
        if (FightScript4.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript4.ehit = 0;
        }
        if (FightScript4.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript4.eatak = 0;
        }
    }
}
