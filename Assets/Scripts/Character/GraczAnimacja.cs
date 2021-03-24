using UnityEngine;

public class GraczAnimacja : MonoBehaviour
{
    public Animator gracz;
    void Start()
    {
        gracz = GetComponent<Animator>();
    }

    void Update()
    {
        if (FightScript.patak == 1)
        {
            gracz.SetTrigger("GraczAtak");
            FightScript.patak = 0;
        }
        if (FightScript.punik == 1)
        {
            gracz.SetTrigger("GraczUnik");
            FightScript.punik = 0;
        }
        if (FightScript.pparowanie == 1)
        {
            gracz.SetTrigger("GraczParowanie");
            FightScript.pparowanie = 0;
        }
        if (FightScript.pgarda == 1)
        {
            gracz.SetTrigger("GraczGarda");
            FightScript.pgarda = 0;
        }
        if (FightScript.phit == 1)
        {
            gracz.SetTrigger("GraczHit");
            FightScript.phit = 0;
        }
    }
}
