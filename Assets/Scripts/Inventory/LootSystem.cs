
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LootSystem : ItemContainer
{
    System.Random rnd = new System.Random();
    [SerializeField] private List<Item> loot1;
    [SerializeField] private Item[] lootitems;
    public Text wygrana;
    public Text przegrana;
    private int check;
    private string nic;
    private string loot;
    private string artefakt;
    private int win;
    static public int maAtrefakt;
    private int miecz;


    private void Update()
    {

    }


    public void Losowanie1()
    {
        check = 50;
        if (Random.Range(0, 101) <= check)
        {
            foreach (Item item in lootitems)
            {
                if (item.Rang == 1)
                {
                    loot1.Add(item);
                }
            }

            int r;
            r = rnd.Next(loot1.Count);

            foreach (Item item in loot1)
            {
                if (r == loot1.IndexOf(item, r))
                {
                    loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = loot;
                    win = 1;
                    AddItem(item.GetCopy());

                    return;
                }
            }
        }
        nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
        wygrana.gameObject.SetActive(false);
        przegrana.gameObject.SetActive(true);
        przegrana.text = nic;

        if (win == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 1)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 2;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }

        if (win == 2)
        {
            check = 10;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 1)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 0;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }
    }

    public void Losowanie2()
    {
        check = 50;
        if (Random.Range(0, 101) <= check)
        {
            foreach (Item item in lootitems)
            {
                if (item.Rang == 1)
                {
                    loot1.Add(item);
                }
            }

            int r;
            r = rnd.Next(loot1.Count);

            foreach (Item item in loot1)
            {
                if (r == loot1.IndexOf(item, r))
                {
                    loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = loot;
                    win = 1;
                    AddItem(item.GetCopy());

                    return;
                }
            }
        }
        nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
        wygrana.gameObject.SetActive(false);
        przegrana.gameObject.SetActive(true);
        przegrana.text = nic;

        if (win == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 1)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 2;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }

        if (win == 2)
        {
            check = 10;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 1)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 0;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }
    }

    public void Losowanie3()
    {
        check = 50;
        if (Random.Range(0, 101) <= check)
        {
            foreach (Item item in lootitems)
            {
                if (item.Rang == 1 || item.Rang == 2)
                {
                    loot1.Add(item);
                }
            }

            int r;
            r = rnd.Next(loot1.Count);

            foreach (Item item in loot1)
            {
                if (r == loot1.IndexOf(item, r))
                {
                    loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = loot;
                    win = 1;
                    AddItem(item.GetCopy());

                    return;
                }
            }
        }
        nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
        wygrana.gameObject.SetActive(false);
        przegrana.gameObject.SetActive(true);
        przegrana.text = nic;

        if (win == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 1 || item.Rang == 2)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 2;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }

        if (win == 2)
        {
            check = 10;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 1 || item.Rang == 2)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 0;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }
    }

    public void Losowanie4()
    {
        check = 50;
        if (Random.Range(0, 101) <= check)
        {
            foreach (Item item in lootitems)
            {
                if (item.Rang == 2)
                {
                    loot1.Add(item);
                }
            }

            int r;
            r = rnd.Next(loot1.Count);

            foreach (Item item in loot1)
            {
                if (r == loot1.IndexOf(item, r))
                {
                    loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = loot;
                    win = 1;
                    AddItem(item.GetCopy());

                    return;
                }
            }
        }
        nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
        wygrana.gameObject.SetActive(false);
        przegrana.gameObject.SetActive(true);
        przegrana.text = nic;

        if (win == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 2)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 2;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }

        if (win == 2)
        {
            check = 10;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 2)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 0;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }
    }

    public void Losowanie5()
    {
        check = 50;
        if (Random.Range(0, 101) <= check)
        {
            foreach (Item item in lootitems)
            {
                if (item.Rang == 2 || item.Rang == 3)
                {
                    loot1.Add(item);
                }
            }

            int r;
            r = rnd.Next(loot1.Count);

            foreach (Item item in loot1)
            {
                if (r == loot1.IndexOf(item, r))
                {
                    loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = loot;
                    win = 1;
                    AddItem(item.GetCopy());

                    return;
                }
            }
        }
        nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
        wygrana.gameObject.SetActive(false);
        przegrana.gameObject.SetActive(true);
        przegrana.text = nic;

        if (win == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 2 || item.Rang == 3)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 2;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }

        if (win == 2)
        {
            check = 10;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 2 || item.Rang == 3)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 0;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }
    }

    public void Losowanie6()
    {
        check = 50;
        if (Random.Range(0, 101) <= check)
        {
            foreach (Item item in lootitems)
            {
                if (item.Rang == 3)
                {
                    loot1.Add(item);
                }
            }

            int r;
            r = rnd.Next(loot1.Count);

            foreach (Item item in loot1)
            {
                if (r == loot1.IndexOf(item, r))
                {
                    loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = loot;
                    win = 1;
                    AddItem(item.GetCopy());

                    return;
                }
            }
        }
        nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
        wygrana.gameObject.SetActive(false);
        przegrana.gameObject.SetActive(true);
        przegrana.text = nic;

        if (win == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 3)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 2;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }

        if (win == 2)
        {
            check = 10;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 3)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = ", " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 0;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            return;
        }
    }

    public void Losowanie7A()
    {
        if (PlayerPrefs.GetInt("maartefakt") != 1)
        {
                foreach (Item item in lootitems)
                {
                if (item.Rang == 4)
                {
                    loot1.Add(item);
                    artefakt = "Po długiej drodze i ostatecznym ciosie zadanym hersztowi i jego bandytom udaje Ci się odzyskać " + "'" + item.ItemName + "'" + "\n \n";
                    przegrana.gameObject.SetActive(false);
                    wygrana.gameObject.SetActive(true);
                    wygrana.text = artefakt;
                    AddItem(item.GetCopy());
                }

            }
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 3)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text += loot;
                        win = 1;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
            wygrana.gameObject.SetActive(false);
            przegrana.gameObject.SetActive(true);
            przegrana.text = artefakt;

            if (win == 1)
            {
                check = 50;
                if (Random.Range(0, 101) <= check)
                {
                    foreach (Item item in lootitems)
                    {
                        if (item.Rang == 3)
                        {
                            loot1.Add(item);
                        }
                    }

                    int r;
                    r = rnd.Next(loot1.Count);

                    foreach (Item item in loot1)
                    {
                        if (r == loot1.IndexOf(item, r))
                        {
                            loot = ", " + "'" + item.ItemName + "'";
                            przegrana.gameObject.SetActive(false);
                            wygrana.gameObject.SetActive(true);
                            wygrana.text += loot;
                            win = 2;
                            AddItem(item.GetCopy());

                            return;
                        }
                    }
                }
                return;
            }

            if (win == 2)
            {
                check = 10;
                if (Random.Range(0, 101) <= check)
                {
                    foreach (Item item in lootitems)
                    {
                        if (item.Rang == 3)
                        {
                            loot1.Add(item);
                        }
                    }

                    int r;
                    r = rnd.Next(loot1.Count);

                    foreach (Item item in loot1)
                    {
                        if (r == loot1.IndexOf(item, r))
                        {
                            loot = ", " + "'" + item.ItemName + "'";
                            przegrana.gameObject.SetActive(false);
                            wygrana.gameObject.SetActive(true);
                            wygrana.text += loot;
                            win = 0;
                            AddItem(item.GetCopy());

                            return;
                        }
                    }
                }
                return;
            }
        }
    
    }

    public void Losowanie7B()
    {
        if (PlayerPrefs.GetInt("maartefakt") == 1)
        {
            check = 50;
            if (Random.Range(0, 101) <= check)
            {
                foreach (Item item in lootitems)
                {
                    if (item.Rang == 3)
                    {
                        loot1.Add(item);
                    }
                }

                int r;
                r = rnd.Next(loot1.Count);

                foreach (Item item in loot1)
                {
                    if (r == loot1.IndexOf(item, r))
                    {
                        loot = "Przedmioty zdobyte w walce: " + "'" + item.ItemName + "'";
                        przegrana.gameObject.SetActive(false);
                        wygrana.gameObject.SetActive(true);
                        wygrana.text = loot;
                        win = 1;
                        AddItem(item.GetCopy());

                        return;
                    }
                }
            }
            nic = "Niestety nie udało Ci się zebrać żadnych przedmiotów po walce.";
            wygrana.gameObject.SetActive(false);
            przegrana.gameObject.SetActive(true);
            przegrana.text = nic;

            if (win == 1)
            {
                check = 50;
                if (Random.Range(0, 101) <= check)
                {
                    foreach (Item item in lootitems)
                    {
                        if (item.Rang == 3)
                        {
                            loot1.Add(item);
                        }
                    }

                    int r;
                    r = rnd.Next(loot1.Count);

                    foreach (Item item in loot1)
                    {
                        if (r == loot1.IndexOf(item, r))
                        {
                            loot = ", " + "'" + item.ItemName + "'";
                            przegrana.gameObject.SetActive(false);
                            wygrana.gameObject.SetActive(true);
                            wygrana.text += loot;
                            win = 2;
                            AddItem(item.GetCopy());

                            return;
                        }
                    }
                }
                return;
            }

            if (win == 2)
            {
                check = 10;
                if (Random.Range(0, 101) <= check)
                {
                    foreach (Item item in lootitems)
                    {
                        if (item.Rang == 3)
                        {
                            loot1.Add(item);
                        }
                    }

                    int r;
                    r = rnd.Next(loot1.Count);

                    foreach (Item item in loot1)
                    {
                        if (r == loot1.IndexOf(item, r))
                        {
                            loot = ", " + "'" + item.ItemName + "'";
                            przegrana.gameObject.SetActive(false);
                            wygrana.gameObject.SetActive(true);
                            wygrana.text += loot;
                            win = 0;
                            AddItem(item.GetCopy());

                            return;
                        }
                    }
                }
                return;
            }
        }
    }

    public void CzyMaArtefakt()
    {
        PlayerPrefs.SetInt("maartefakt", 1);
        PlayerPrefs.Save();
    }


}