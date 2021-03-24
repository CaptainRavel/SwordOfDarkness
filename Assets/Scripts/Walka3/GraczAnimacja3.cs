using UnityEngine;

public class GraczAnimacja3 : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript3.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript3.patak = 0;
        }
        if (FightScript3.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript3.punik = 0;
        }
        if (FightScript3.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript3.pparowanie = 0;
        }
        if (FightScript3.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript3.pgarda = 0;
        }
        if (FightScript3.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript3.phit = 0;
        }
    }
}
