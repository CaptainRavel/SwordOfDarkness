using System.Text;
using UnityEngine;
using UnityEngine.UI;

	public class StatTooltip : MonoBehaviour
	{
		public static StatTooltip Instance;

		[SerializeField] Text statNameText;
		[SerializeField] Text finalValueText;
		[SerializeField] Text modifiersListText;
        [SerializeField] Text statdecsription;

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

		public void ShowTooltip(CharacterStat stat, string statName)
		{
			gameObject.SetActive(true);

            statNameText.text = FirstLetterToUpper(statName);
            finalValueText.text = GetValueText(stat);
            modifiersListText.text = "MODYFIKATORY: \n" + GetModifiersText(stat);
            if (statName == "SIŁA")
            {
                statdecsription.text = "Siła – opisuje siłę fizyczną postaci. Jest to kluczowa cecha dla postaci, ponieważ wpływa na zadawane obrażenia.";
            }
            else if (statName == "ZRĘCZNOŚĆ")
            {
                statdecsription.text = "Zręczność – ta umiejętność wpływa na modyfikator trafienia.";
            }
            else if (statName == "WYTRZYMAŁOŚĆ")
            {
                statdecsription.text = "Wytrzymałość – opisuje odporność na obrażenia. Dzięki Wytrzymałości obrażenia każdej strefy są redukowane.";
            }
            else if (statName == "REFLEKS")
            {
                statdecsription.text = "Refleks – dzięki niemu postać będzie potrafiła lepiej się bronić poprzez unikanie ataków.";
            }
            else if (statName == "ZDROWIE")
            {
                statdecsription.text = "Zdrowie – opisuje jak długo postać może przeżyć na polu walki.";
            }
            else if (statName == "KONDYCJA")
            {
                statdecsription.text = "Kondycja – ważna dla wszystkich atakujących fizyczne i nie tylko jest zużywana przy atakowaniu i obronie.";
            }
            else if (statName == "REDUKCJA GARDĄ")
            {
                statdecsription.text = "Garda - jest to rodzaj obrony, w którym obrażenia są redukowane.";
            }
            else if (statName == "SZANSA NA KONTRATAK")
            {
                statdecsription.text = "Kontratak - Dodatkowy atak możliwy do wykonania po poprawnym sparowaniu.";
            }
        else if (statName == "OBRAŻENIA MINIMALNE")
        {
            statdecsription.text = "Określa ile najmniej możesz zadać punktów obrażeń wrogowi podczas trafienia.";
        }
        else if (statName == "OBRAŻENIA MAKSYMALNE")
        {
            statdecsription.text = "Określa ile najwięcej możesz zadać punktów obrażeń wrogowi podczas trafienia.";
        }
        else
            {
                statdecsription.text = "Tutaj pojawi się niedługo opis danej cechy..";
            }
        }

		public void HideTooltip()
		{
			gameObject.SetActive(false);
		}

		private string GetValueText(CharacterStat stat)
		{
			sb.Length = 0;

            
            sb.Append("Całkowita ilość:  ");
            sb.Append(stat.Value);
			sb.Append("\n");
			sb.Append(stat.BaseValue);
			sb.Append("  (baza) +  ");
			sb.Append((float)System.Math.Round(stat.Value - stat.BaseValue, 4));
			sb.Append(" (modyfikator)");

			return sb.ToString();
		}

		private string GetModifiersText(CharacterStat stat)
		{
			sb.Length = 0;

			for (int i = 0; i < stat.StatModifiers.Count; i++)
			{
				StatModifier mod = stat.StatModifiers[i];

                sb.Append(((Item)mod.Source).ItemName);
				sb.Append(": ");

				if (mod.Value > 0) {
					sb.Append("+");
				}

				if (mod.Type == StatModType.Flat) {
					sb.Append(mod.Value);
				} else {
					sb.Append(mod.Value);
					sb.Append("%");
				}

				if (i < stat.StatModifiers.Count - 1) {
					sb.AppendLine();
				}
			}

			return sb.ToString();
		}


		private string FirstLetterToUpper(string s)
		{
			if (string.IsNullOrEmpty(s))
				return null;

			char[] a = s.ToCharArray();
			a[0] = char.ToUpper(a[0]);
			return new string(a);
		}
	}
