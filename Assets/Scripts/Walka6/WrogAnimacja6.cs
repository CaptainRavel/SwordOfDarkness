using UnityEngine;

public class WrogAnimacja6 : MonoBehaviour
{
    public Animator wrog;
    void Start()
    {
        wrog = GetComponent<Animator>();
    }

    void Update()

    {

        if (FightScript6.eunik == 1)
        {
            wrog.SetTrigger("WrogUnik");
            FightScript6.eunik = 0;
        }
        if (FightScript6.eparowanie == 1)
        {
            wrog.SetTrigger("WrogParowanie");
            FightScript6.eparowanie = 0;
        }
        if (FightScript6.egarda == 1)
        {
            wrog.SetTrigger("WrogGarda");
            FightScript6.egarda = 0;
        }
        if (FightScript6.ehit == 1)
        {
            wrog.SetTrigger("WrogHit");
            FightScript6.ehit = 0;
        }
        if (FightScript6.eatak == 1)
        {
            wrog.SetTrigger("WrogAtak");
            FightScript6.eatak = 0;
        }
    }
}
