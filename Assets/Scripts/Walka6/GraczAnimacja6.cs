using UnityEngine;

public class GraczAnimacja6 : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript6.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript6.patak = 0;
        }
        if (FightScript6.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript6.punik = 0;
        }
        if (FightScript6.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript6.pparowanie = 0;
        }
        if (FightScript6.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript6.pgarda = 0;
        }
        if (FightScript6.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript6.phit = 0;
        }
    }
}
