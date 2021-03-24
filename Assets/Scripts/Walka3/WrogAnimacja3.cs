using UnityEngine;

public class WrogAnimacja3 : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript3.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript3.eunik = 0;
        }
        if (FightScript3.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript3.eparowanie = 0;
        }
        if (FightScript3.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript3.egarda = 0;
        }
        if (FightScript3.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript3.ehit = 0;
        }
        if (FightScript3.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript3.eatak = 0;
        }
    }
}
