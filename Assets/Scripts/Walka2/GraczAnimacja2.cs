using UnityEngine;

public class GraczAnimacja2 : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript2.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript2.patak = 0;
        }
        if (FightScript2.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript2.punik = 0;
        }
        if (FightScript2.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript2.pparowanie = 0;
        }
        if (FightScript2.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript2.pgarda = 0;
        }
        if (FightScript2.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript2.phit = 0;
        }
    }
}
