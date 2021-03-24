using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBlockScript : MonoBehaviour
{

    public Button walka2;
    public Button walka3;
    public Button walka4;
    public Button walka5;
    public Button walka6;
    public Button walka7;
    public Text fabText;
    private string rozdzialI;
    private string rozdzialII;
    private string rozdzialIII;
    private string rozdzialIV;
    private string rozdzialV;
    private string rozdzialVI;
    private string rozdzialVII;
    private string epilogA;
    private string epilogB;
    public static int ktorawalka;

    void Start()
    {
        rozdzialI = "Rozdział I \nPewnego dnia miasto, w którym mieszkasz zostało zaatakowane. Celem ataku wroga jest wykradzenie potężnego artefaktu – Miecza Ciemności. Od lat przedmiot ten znajdował się w świątyni pilnowany przez strażników. Niestety dziś nadszedł dzień, w którym ów artefakt został skradziony. Na północy ocalali z bitwy założyli obóz. Tam teraz zamierzasz się udać. Po drodze napotykasz kilku szwędających się napastników… \n \n";
        rozdzialII = "Rozdział II \nDopiero co udało ci się zbiec z rodzinnego miasta a już musisz stawić czoła leśnym bandytom. Postanawiasz uporać się z nimi i ruszyć dalej na północ szukając pomocy wśród żołnierzy stacjonujących na wybrzeżu. \n \n";
        rozdzialIII = "Rozdział III \nUdało ci się odnaleźć żołnierzy. Niestety ich przywódca nie ma zamiaru ci pomagać i żadne argumenty nie przemawiają do niego.Oprócz jednego – argumentu siły… \n \n";
        rozdzialIV = "Rozdział IV \nWykazałeś się większą siłą od dowódcy oddziału i ten zgodził się pomóc w odnalezieniu Miecza Ciemności. Najpierw jednak musicie odbić fort na rzece, który także padł ofiarą wrogiej napaści. \n \n";
        rozdzialV = "Rozdział V \nPo odbiciu fortu i przesłuchaniu jeńców dowiedziałeś się, że należy udać się na wschód, gdzie w prastarych ruinach odnajdziesz tego, który wykradł artefakt. Podczas podróży napotykasz kolejną zdewastowaną wioskę. Okazuje się, że są tutaj orkowie. Postanawiasz się z nimi rozprawić. \n \n";
        rozdzialVI = "Rozdział VI  \nPrzekroczyłeś już rzekę i dotarłeś do kopalni. Ta jednak okazuje się splądrowana. Wygląda na to, że Ktokolwiek ukradł Miecz Ciemności, ma większe ambicje niż tylko posiadanie tego artefaktu. Nie masz innego wyjścia, zanim ruszysz dalej musisz pozbyć się nieproszonych gości. \n \n";
        rozdzialVII = "Rozdział VII \nPrzemierzywszy gęsty las i pokonując po drodze hordy pomniejszych orków dotarłeś w końcu do prastarych ruin. Herszt orków już na ciebie czekał. Musisz teraz stoczyć ostateczną walkę.\n \n";
        epilogA = "Odzyskałeś Miecz Ciemności. \nGratulacje. Teraz czeka cię odbudowa rodzinnego miasta i zabezpieczenie artefaktu przed innymi niepożądanymi atakami. \n \n";
        epilogB = "Wygląda na to, że herszt nie miał przy sobie Miecza Ciemności. Prawdopodobnie przekazał go innym złowrogim istotom. Tak czy owak czekają cię dalsze poszukiwania artefaktu. \n \n";

        fabText.text = rozdzialI;

        if (PlayerPrefs.GetInt("ContinueGame") == 1)
        {
            PlayerPrefs.GetInt("battlelevel");
        }
        else
        {
            PlayerPrefs.SetInt("battlelevel", 1);
        }
        if (PlayerPrefs.GetInt("battlelevel") == 1)
        {
            walka2.interactable = false;
            walka3.interactable = false;
            walka4.interactable = false;
            walka5.interactable = false;
            walka6.interactable = false;
            walka7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 2)
        {
            walka2.interactable = true;
            walka3.interactable = false;
            walka4.interactable = false;
            walka5.interactable = false;
            walka6.interactable = false;
            walka7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 3)
        {
            walka2.interactable = true;
            walka3.interactable = true;
            walka4.interactable = false;
            walka5.interactable = false;
            walka6.interactable = false;
            walka7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 4)
        {
            walka2.interactable = true;
            walka3.interactable = true;
            walka4.interactable = true;
            walka5.interactable = false;
            walka6.interactable = false;
            walka7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 5)
        {
            walka2.interactable = true;
            walka3.interactable = true;
            walka4.interactable = true;
            walka5.interactable = true;
            walka6.interactable = false;
            walka7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 6)
        {
            walka2.interactable = true;
            walka3.interactable = true;
            walka4.interactable = true;
            walka5.interactable = true;
            walka6.interactable = true;
            walka7.interactable = false;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 7)
        {
            walka2.interactable = true;
            walka3.interactable = true;
            walka4.interactable = true;
            walka5.interactable = true;
            walka6.interactable = true;
            walka7.interactable = true;
        }

        if (PlayerPrefs.GetInt("battlelevel") == 2)
        {
            fabText.text = rozdzialII + rozdzialI;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 3)
        {
            fabText.text = rozdzialIII + rozdzialII + rozdzialI;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 4)
        {
            fabText.text = rozdzialIV + rozdzialIII + rozdzialII + rozdzialI;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 5)
        {
            fabText.text = rozdzialV + rozdzialIV + rozdzialIII + rozdzialII + rozdzialI;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 6)
        {
            fabText.text = rozdzialVI + rozdzialV + rozdzialIV + rozdzialIII + rozdzialII + rozdzialI;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 7)
        {
            fabText.text = rozdzialVII + rozdzialVI + rozdzialV + rozdzialIV + rozdzialIII + rozdzialII + rozdzialI; ;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 8 )
        {
            fabText.text = epilogA + rozdzialVII + rozdzialVI + rozdzialV + rozdzialIV + rozdzialIII + rozdzialII + rozdzialI;
        }

    }

    void Update()
    {


    }
}
