using UnityEngine;

public class WrogAnimacja2 : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript2.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript2.eunik = 0;
        }
        if (FightScript2.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript2.eparowanie = 0;
        }
        if (FightScript2.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript2.egarda = 0;
        }
        if (FightScript2.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript2.ehit = 0;
        }
        if (FightScript2.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript2.eatak = 0;
        }
    }
}
