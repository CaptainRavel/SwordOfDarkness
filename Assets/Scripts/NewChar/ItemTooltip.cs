using UnityEngine;
using UnityEngine.UI;
using System.Text;


	public class ItemTooltip : MonoBehaviour
	{
		public static ItemTooltip Instance;

		[SerializeField] Text nameText;
		[SerializeField] Text slotTypeText;
		[SerializeField] Text statsText;
    [SerializeField] Text opisText;

    private StringBuilder sb = new StringBuilder();

		private void Awake()
		{
			if (Instance == null) {
				Instance = this;
			} else {
				Destroy(this);
			}
			gameObject.SetActive(false);
		}

		public void ShowTooltip(Item itemToShow)
		{
			if (!(itemToShow is EquippableItem)) {
				return;
			}

			EquippableItem item = (EquippableItem)itemToShow;

			gameObject.SetActive(true);

			nameText.text = item.ItemName;
			slotTypeText.text = item.EquipmentType.ToString();

			sb.Length = 0;

			AddStatText(item.SiłaBonus, " do siły");
			AddStatText(item.ZręcznośćBonus, "  do zręczności");
			AddStatText(item.WytrzymałośćBonus, " do wytrzymałości");
			AddStatText(item.RefleksBonus, " do refleksu");
            AddStatText(item.ZdrowieBonus, " do zdrowia");
            AddStatText(item.KondycjaBonus, " do kondycji");

        AddStatText(item.GardaProcentBonus, "% redukcji obrażeń z gardy");
        AddStatText(item.KontratakProcentBonus, "% szansy na udany kontratak");


        if (item.EquipmentType.ToString() == "Broń")
        {
            statsText.text = "SPECYFIKACJA: " + "\n" + "\n"  + "OBRAŻENIA " + item.ObrażeniaMinimalne + "k" + item.ObrażeniaMaksymalne + "\n" + sb.ToString();
        }
        else
        {
            statsText.text = "SPECYFIKACJA: " + "\n" + "\n" + sb.ToString();
        }

        opisText.text = item.Opis;
		}

		public void HideTooltip()
		{
			gameObject.SetActive(false);
		}

		private void AddStatText(float statBonus, string statName)
		{
			if (statBonus != 0)
			{
				if (sb.Length > 0)
					sb.AppendLine();

				if (statBonus > 0)
					sb.Append("+");

				sb.Append(statBonus);
				sb.Append(statName);
			}
		}
	}

