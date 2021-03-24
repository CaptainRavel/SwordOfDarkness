using UnityEngine;

public class WrogAnimacja5 : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript5.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript5.eunik = 0;
        }
        if (FightScript5.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript5.eparowanie = 0;
        }
        if (FightScript5.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript5.egarda = 0;
        }
        if (FightScript5.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript5.ehit = 0;
        }
        if (FightScript5.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript5.eatak = 0;
        }
    }
}
