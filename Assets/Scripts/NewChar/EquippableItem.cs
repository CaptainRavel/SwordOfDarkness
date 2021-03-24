using UnityEngine;


	public enum EquipmentType
	{
		Hełm,
		Zbroja,
		Buty,
		Broń,
		Tarcza,
	}

	[CreateAssetMenu]
	public class EquippableItem : Item
	{
    
    [Space]
    public int ObrażeniaMinimalne;
    public int ObrażeniaMaksymalne;
    [Space]
        public int SiłaBonus;
		public int ZręcznośćBonus;
		public int WytrzymałośćBonus;
		public int RefleksBonus;
        public int ZdrowieBonus;
        public int KondycjaBonus;
    [Space]
public int GardaProcentBonus;
public int KontratakProcentBonus;


		public EquipmentType EquipmentType;
    [Space]
    public string Opis;

    public override Item GetCopy()
    {
        return Instantiate(this);
    }
    public override void Destroy()
    {
        Destroy(this);
    }

    public void Equip(Character c)
		{
			if (SiłaBonus != 0)
				c.Siła.AddModifier(new StatModifier(SiłaBonus, StatModType.Flat, this));
			if (ZręcznośćBonus != 0)
				c.Zręczność.AddModifier(new StatModifier(ZręcznośćBonus, StatModType.Flat, this));
			if (WytrzymałośćBonus != 0)
				c.Wytrzymałość.AddModifier(new StatModifier(WytrzymałośćBonus, StatModType.Flat, this));
			if (RefleksBonus != 0)
				c.Refleks.AddModifier(new StatModifier(RefleksBonus, StatModType.Flat, this));
            if (ZdrowieBonus != 0)
                c.Zdrowie.AddModifier(new StatModifier(ZdrowieBonus, StatModType.Flat, this));
            if (KondycjaBonus != 0)
                c.Kodycja.AddModifier(new StatModifier(KondycjaBonus, StatModType.Flat, this));
            if (ObrażeniaMinimalne!= 0)
                c.ObrażeniaMinimalne.AddModifier(new StatModifier(ObrażeniaMinimalne, StatModType.Flat, this));
            if (ObrażeniaMaksymalne != 0)
                c.ObrażeniaMaksymalne.AddModifier(new StatModifier(ObrażeniaMaksymalne, StatModType.Flat, this));

        if (GardaProcentBonus != 0)
            c.GardaProcent.AddModifier(new StatModifier(GardaProcentBonus, StatModType.PercentAdd, this));
        if (KontratakProcentBonus != 0)
            c.KontratakProcent.AddModifier(new StatModifier(KontratakProcentBonus, StatModType.PercentAdd, this));
    }

		public void Unequip(Character c)
		{
			c.Siła.RemoveAllModifiersFromSource(this);
			c.Zręczność.RemoveAllModifiersFromSource(this);
			c.Wytrzymałość.RemoveAllModifiersFromSource(this);
			c.Refleks.RemoveAllModifiersFromSource(this);
            c.Zdrowie.RemoveAllModifiersFromSource(this);
            c.Kodycja.RemoveAllModifiersFromSource(this);
            c.ObrażeniaMinimalne.RemoveAllModifiersFromSource(this);
            c.ObrażeniaMaksymalne.RemoveAllModifiersFromSource(this);
        c.GardaProcent.RemoveAllModifiersFromSource(this);
        c.KontratakProcent.RemoveAllModifiersFromSource(this);
    }
    public override string GetItemType()
    {
        return EquipmentType.ToString();
    }
}
