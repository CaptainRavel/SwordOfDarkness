using UnityEngine;

public class GraczAnimacja7 : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript7.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript7.patak = 0;
        }
        if (FightScript7.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript7.punik = 0;
        }
        if (FightScript7.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript7.pparowanie = 0;
        }
        if (FightScript7.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript7.pgarda = 0;
        }
        if (FightScript7.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript7.phit = 0;
        }
    }
}
