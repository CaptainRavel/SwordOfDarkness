using UnityEngine;

public class GraczAnimacja5 : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript5.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript5.patak = 0;
        }
        if (FightScript5.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript5.punik = 0;
        }
        if (FightScript5.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript5.pparowanie = 0;
        }
        if (FightScript5.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript5.pgarda = 0;
        }
        if (FightScript5.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript5.phit = 0;
        }
    }
}
