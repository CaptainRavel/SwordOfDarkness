using UnityEngine;

public class WrogAnimacja7 : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript7.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript7.eunik = 0;
        }
        if (FightScript7.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript7.eparowanie = 0;
        }
        if (FightScript7.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript7.egarda = 0;
        }
        if (FightScript7.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript7.ehit = 0;
        }
        if (FightScript7.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript7.eatak = 0;
        }
    }
}
