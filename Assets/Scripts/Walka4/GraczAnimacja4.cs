using UnityEngine;

public class GraczAnimacja4 : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript4.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript4.patak = 0;
        }
        if (FightScript4.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript4.punik = 0;
        }
        if (FightScript4.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript4.pparowanie = 0;
        }
        if (FightScript4.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript4.pgarda = 0;
        }
        if (FightScript4.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript4.phit = 0;
        }
    }
}
