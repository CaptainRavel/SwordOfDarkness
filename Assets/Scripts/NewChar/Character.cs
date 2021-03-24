using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    [Header("Stats")]
    public CharacterStat Siła;
    public CharacterStat Zręczność;
    public CharacterStat Wytrzymałość;
    public CharacterStat Refleks;
    public CharacterStat Zdrowie;
    public CharacterStat Kodycja;
    public CharacterStat Poziom;
    public CharacterStat GardaProcent;
    public CharacterStat KontratakProcent;
    public CharacterStat ObrażeniaMinimalne;
    public CharacterStat ObrażeniaMaksymalne;
    

    static public float maxHealth;
    static public float currentHealth;
    static public float maxKon;
    static public float currentKon;
    public static int sila;
    public static int zrecznosc;
    public static int wytrzymalosc;
    public static int refleks;
    public static int gardapercent;
    public static int kontrapercent;
    public static int obrmin;
    public static int obrmax;
    public static int level;
    static public float bcurrentHealth;
    static public float bcurrentKon;
    public static int bsila;
    public static int bzrecznosc;
    public static int bwytrzymalosc;
    public static int brefleks;
    public static int bgardapercent;
    public static int bkontrapercent;
    public static int bobrmin;
    public static int bobrmax;
    public static int blevel;

    [Header("Public")]
    public Inventory Inventory;
    public EquipmentPanel EquipmentPanel;

    [Header("Serialize Field")]
    [SerializeField] StatPanel statPanel;
    [SerializeField] ItemTooltip itemTooltip;
    [SerializeField] Image draggableItem;
    [SerializeField] DropItemArea dropItemArea;
    [SerializeField] QuestionDialog reallyDropItemDialog;
    [SerializeField] ItemSaveManager itemSaveManager;

    private BaseItemSlot dragItemSlot;

    private void OnValidate()
    {
        if (itemTooltip == null)
            itemTooltip = FindObjectOfType<ItemTooltip>();
    }

    private void Awake()
    {
        statPanel.SetStats(Siła, Zręczność, Wytrzymałość, Refleks, Zdrowie, Kodycja, GardaProcent, KontratakProcent, ObrażeniaMinimalne, ObrażeniaMaksymalne);
        statPanel.UpdateStatValues();


        // Setup Events:
        // Right Click
        Inventory.OnRightClickEvent += InventoryRightClick;
        EquipmentPanel.OnRightClickEvent += EquipmentPanelRightClick;
        // Pointer Enter
        Inventory.OnPointerEnterEvent += ShowTooltip;
        EquipmentPanel.OnPointerEnterEvent += ShowTooltip;
        // Pointer Exit
        Inventory.OnPointerExitEvent += HideTooltip;
        EquipmentPanel.OnPointerExitEvent += HideTooltip;
        // Begin Drag
        Inventory.OnBeginDragEvent += BeginDrag;
        EquipmentPanel.OnBeginDragEvent += BeginDrag;
        // End Drag
        Inventory.OnEndDragEvent += EndDrag;
        EquipmentPanel.OnEndDragEvent += EndDrag;
        // Drag
        Inventory.OnDragEvent += Drag;
        EquipmentPanel.OnDragEvent += Drag;
        // Drop
        Inventory.OnDropEvent += Drop;
        EquipmentPanel.OnDropEvent += Drop;
        dropItemArea.OnDropEvent += DropItemOutsideUI;
    }

    private void Start()
    {

        if (PlayerPrefs.GetInt("ContinueGame") == 1)
        {
            PlayerSaveScript data1 = PlayerSaving.LoadPlayer1();
            Poziom.BaseValue = data1.blevel;
            Siła.BaseValue = data1.bsiła;
            Zręczność.BaseValue = data1.bzręcznosc;
            Wytrzymałość.BaseValue = data1.bwytrzymalosc;
            Refleks.BaseValue = data1.brefleks;
            Zdrowie.BaseValue = data1.bcurrentHP;
            Kodycja.BaseValue = data1.bcurrentKon;
            GardaProcent.BaseValue = data1.bgrada;
            KontratakProcent.BaseValue = data1.bkontratak;
            ObrażeniaMinimalne.BaseValue = data1.bobrazeniaMin;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
            currentHealth = data1.bcurrentHP;
            currentKon = data1.bcurrentKon;

            Debug.Log("Vitals from data = " + data1.currentHP + " i " + data1.currentKon);

            if (itemSaveManager != null)
            {
                itemSaveManager.LoadEquipment(this);
                itemSaveManager.LoadInventory(this);
            }
        }
        else
        {
            Poziom.BaseValue = 1;
            Siła.BaseValue = 10;
            Zręczność.BaseValue = 10;
            Wytrzymałość.BaseValue = 10;
            Refleks.BaseValue = 10;
            Zdrowie.BaseValue = 100;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 100;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 30;
            KontratakProcent.BaseValue = 25;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;

        }

        if (PlayerPrefs.GetInt("battlelevel") == 2)
        {
            Poziom.BaseValue = 2;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 3) 
        {
            Poziom.BaseValue = 3;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 4) 
        {
            Poziom.BaseValue = 4;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 5) 
        {
            Poziom.BaseValue = 5;
        }
        if (PlayerPrefs.GetInt("battlelevel") == 6) 
        {
            Poziom.BaseValue = 6;
        }
        if (PlayerPrefs.GetInt("battlelevel") >= 7) 
        {
            Poziom.BaseValue = 7;
        }


    }

    private void Update()
    {


        if (Poziom.BaseValue >= 7)
        {
            Poziom.BaseValue = 7;
        }

        if (Poziom.BaseValue == 1)
        {
            Siła.BaseValue = 10;
            Zręczność.BaseValue = 10;
            Wytrzymałość.BaseValue = 10;
            Refleks.BaseValue = 10;
            Zdrowie.BaseValue = 100;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 100;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 30;
            KontratakProcent.BaseValue = 25;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 2)
        {
            Siła.BaseValue = 20;
            Zręczność.BaseValue = 20;
            Wytrzymałość.BaseValue = 15;
            Refleks.BaseValue = 15;
            Zdrowie.BaseValue = 120;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 120;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 35;
            KontratakProcent.BaseValue = 30;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 3)
        {
            Siła.BaseValue = 30;
            Zręczność.BaseValue = 30;
            Wytrzymałość.BaseValue = 20;
            Refleks.BaseValue = 20;
            Zdrowie.BaseValue = 140;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 140;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 40;
            KontratakProcent.BaseValue = 35;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 4)
        {
            Siła.BaseValue = 40;
            Zręczność.BaseValue = 40;
            Wytrzymałość.BaseValue = 25;
            Refleks.BaseValue = 25;
            Zdrowie.BaseValue = 160;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 160;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 45;
            KontratakProcent.BaseValue = 40;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 5)
        {
            Siła.BaseValue = 50;
            Zręczność.BaseValue = 50;
            Wytrzymałość.BaseValue = 30;
            Refleks.BaseValue = 30;
            Zdrowie.BaseValue = 180;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 180;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 50;
            KontratakProcent.BaseValue = 45;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 6)
        {
            Siła.BaseValue = 60;
            Zręczność.BaseValue = 60;
            Wytrzymałość.BaseValue = 35;
            Refleks.BaseValue = 35;
            Zdrowie.BaseValue = 200;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 200;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 55;
            KontratakProcent.BaseValue = 50;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 7)
        {
            Siła.BaseValue = 70;
            Zręczność.BaseValue = 70;
            Wytrzymałość.BaseValue = 40;
            Refleks.BaseValue = 40;
            Zdrowie.BaseValue = 220;
            currentHealth = Zdrowie.Value;
            maxHealth = currentHealth;
            Kodycja.BaseValue = 220;
            currentKon = Kodycja.Value;
            maxKon = currentKon;
            GardaProcent.BaseValue = 60;
            KontratakProcent.BaseValue = 55;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
               

        sila = (int)Siła.Value;
        zrecznosc = (int)Zręczność.Value;
        wytrzymalosc = (int)Wytrzymałość.Value;
        refleks = (int)Refleks.Value;
        gardapercent = (int)GardaProcent.Value;
        kontrapercent = (int)KontratakProcent.Value;
        obrmin = (int)ObrażeniaMinimalne.Value;
        obrmax = (int)ObrażeniaMaksymalne.Value;
        level = (int)Poziom.BaseValue;
        bsila = (int)Siła.BaseValue;
        bzrecznosc = (int)Zręczność.BaseValue;
        bwytrzymalosc = (int)Wytrzymałość.BaseValue;
        brefleks = (int)Refleks.BaseValue;
        bgardapercent = (int)GardaProcent.BaseValue;
        bkontrapercent = (int)KontratakProcent.BaseValue;
        bobrmin = (int)ObrażeniaMinimalne.BaseValue;
        bobrmax = (int)ObrażeniaMaksymalne.BaseValue;
        blevel = (int)Poziom.BaseValue;
    }

    public void SaveEQ()
    {
        itemSaveManager.SaveEquipment(this);
        itemSaveManager.SaveInventory(this);
    }
    public void SavePlayer1()
    {
        PlayerSaving.SavePlayer1(this);
    }

    private void OnDestroy()
    {
        if (itemSaveManager != null)
        {
            itemSaveManager.SaveEquipment(this);
            itemSaveManager.SaveInventory(this);
        }
    }

    public void LevelUP()
    {
        Poziom.BaseValue++;
    }

    private void InventoryRightClick(BaseItemSlot itemSlot)
    {
        if (itemSlot.Item is EquippableItem)
        {
            Equip((EquippableItem)itemSlot.Item);
        }
    }

    private void EquipmentPanelRightClick(BaseItemSlot itemSlot)
    {
        if (itemSlot.Item is EquippableItem)
        {
            Unequip((EquippableItem)itemSlot.Item);
        }
    }

    private void ShowTooltip(BaseItemSlot itemSlot)
    {
        if (itemSlot.Item != null)
        {
            itemTooltip.ShowTooltip(itemSlot.Item);
        }
    }

    private void HideTooltip(BaseItemSlot itemSlot)
    {
        if (itemTooltip.gameObject.activeSelf)
        {
            itemTooltip.HideTooltip();
        }
    }

    private void BeginDrag(BaseItemSlot itemSlot)
    {
        if (itemSlot.Item != null)
        {
            dragItemSlot = itemSlot;
            draggableItem.sprite = itemSlot.Item.Icon;
            draggableItem.transform.position = Input.mousePosition;
            draggableItem.gameObject.SetActive(true);
        }
    }

    private void Drag(BaseItemSlot itemSlot)
    {
        draggableItem.transform.position = Input.mousePosition;
    }

    private void EndDrag(BaseItemSlot itemSlot)
    {
        dragItemSlot = null;
        draggableItem.gameObject.SetActive(false);
    }

    private void Drop(BaseItemSlot dropItemSlot)
    {
        if (dragItemSlot == null) return;

        if (dropItemSlot.CanAddStack(dragItemSlot.Item))
        {
            AddStacks(dropItemSlot);
        }
        else if (dropItemSlot.CanReceiveItem(dragItemSlot.Item) && dragItemSlot.CanReceiveItem(dropItemSlot.Item))
        {
            SwapItems(dropItemSlot);
        }
    }

    private void AddStacks(BaseItemSlot dropItemSlot)
    {
        int numAddableStacks = dropItemSlot.Item.MaximumStacks - dropItemSlot.Amount;
        int stacksToAdd = Mathf.Min(numAddableStacks, dragItemSlot.Amount);

        dropItemSlot.Amount += stacksToAdd;
        dragItemSlot.Amount -= stacksToAdd;
    }

    private void SwapItems(BaseItemSlot dropItemSlot)
    {
        EquippableItem dragEquipItem = dragItemSlot.Item as EquippableItem;
        EquippableItem dropEquipItem = dropItemSlot.Item as EquippableItem;

        if (dropItemSlot is EquipmentSlot)
        {
            if (dragEquipItem != null) dragEquipItem.Equip(this);
            if (dropEquipItem != null) dropEquipItem.Unequip(this);
        }
        if (dragItemSlot is EquipmentSlot)
        {
            if (dragEquipItem != null) dragEquipItem.Unequip(this);
            if (dropEquipItem != null) dropEquipItem.Equip(this);
        }
        statPanel.UpdateStatValues();

        Item draggedItem = dragItemSlot.Item;
        int draggedItemAmount = dragItemSlot.Amount;

        dragItemSlot.Item = dropItemSlot.Item;
        dragItemSlot.Amount = dropItemSlot.Amount;

        dropItemSlot.Item = draggedItem;
        dropItemSlot.Amount = draggedItemAmount;
    }

    private void DropItemOutsideUI()
    {
        if (dragItemSlot == null) return;

        reallyDropItemDialog.Show();
        BaseItemSlot slot = dragItemSlot;
        reallyDropItemDialog.OnYesEvent += () => DestroyItemInSlot(slot);
    }

    public void DestroyItemInSlot(BaseItemSlot itemSlot)
    {
        if (itemSlot.Item == null)
        {
            itemSlot.Item = null;
        }
        else
        {
            if (itemSlot is EquipmentSlot)
            {
                EquippableItem equippableItem = (EquippableItem)itemSlot.Item;
                equippableItem.Unequip(this);
            }

            itemSlot.Item.Destroy();
            itemSlot.Item = null;
        }
    }

    public void Equip(EquippableItem item)
    {
        if (Inventory.RemoveItem(item))
        {
            EquippableItem previousItem;
            if (EquipmentPanel.AddItem(item, out previousItem))
            {
                if (previousItem != null)
                {
                    Inventory.AddItem(previousItem);
                    previousItem.Unequip(this);
                    statPanel.UpdateStatValues();
                }
                item.Equip(this);
                statPanel.UpdateStatValues();
            }
            else
            {
                Inventory.AddItem(item);
            }
        }
    }

    public void Unequip(EquippableItem item)
    {
        if (Inventory.CanAddItem(item) && EquipmentPanel.RemoveItem(item))
        {
            item.Unequip(this);
            statPanel.UpdateStatValues();
            Inventory.AddItem(item);
        }
    }

    private ItemContainer openItemContainer;

    private void TransferToItemContainer(BaseItemSlot itemSlot)
    {
        Item item = itemSlot.Item;
        if (item != null && openItemContainer.CanAddItem(item))
        {
            Inventory.RemoveItem(item);
            openItemContainer.AddItem(item);
        }
    }

    private void TransferToInventory(BaseItemSlot itemSlot)
    {
        Item item = itemSlot.Item;
        if (item != null && Inventory.CanAddItem(item))
        {
            openItemContainer.RemoveItem(item);
            Inventory.AddItem(item);
        }
    }

    public void OpenItemContainer(ItemContainer itemContainer)
    {
        openItemContainer = itemContainer;

        Inventory.OnRightClickEvent -= InventoryRightClick;
        Inventory.OnRightClickEvent += TransferToItemContainer;

        itemContainer.OnRightClickEvent += TransferToInventory;

        itemContainer.OnPointerEnterEvent += ShowTooltip;
        itemContainer.OnPointerExitEvent += HideTooltip;
        itemContainer.OnBeginDragEvent += BeginDrag;
        itemContainer.OnEndDragEvent += EndDrag;
        itemContainer.OnDragEvent += Drag;
        itemContainer.OnDropEvent += Drop;
    }

    public void CloseItemContainer(ItemContainer itemContainer)
    {
        openItemContainer = null;

        Inventory.OnRightClickEvent += InventoryRightClick;
        Inventory.OnRightClickEvent -= TransferToItemContainer;

        itemContainer.OnRightClickEvent -= TransferToInventory;

        itemContainer.OnPointerEnterEvent -= ShowTooltip;
        itemContainer.OnPointerExitEvent -= HideTooltip;
        itemContainer.OnBeginDragEvent -= BeginDrag;
        itemContainer.OnEndDragEvent -= EndDrag;
        itemContainer.OnDragEvent -= Drag;
        itemContainer.OnDropEvent -= Drop;
    }

    public void UpdateStatValues()
    {
        statPanel.UpdateStatValues();
    }
}


/*
public class Character : MonoBehaviour
	{

 public CharacterStat Siła;
 public CharacterStat Zręczność;
 public CharacterStat Wytrzymałość;
public CharacterStat Refleks;
public CharacterStat Zdrowie;
public CharacterStat Kodycja;
public CharacterStat Poziom;
public CharacterStat GardaProcent;
public CharacterStat KontratakProcent;
public CharacterStat ObrażeniaMinimalne;
 public CharacterStat ObrażeniaMaksymalne;

    static public float maxHealth;
    static public float currentHealth;
    static public float maxKon;
    static public float currentKon;
    public static int sila;
    public static int zrecznosc;
    public static int wytrzymalosc;
    public static int refleks;
    public static int gardapercent;
    public static int kontrapercent;
    public static int obrmin;
    public static int obrmax;
    public static int level;
    static public float bcurrentHealth;
    static public float bcurrentKon;
    public static int bsila;
    public static int bzrecznosc;
    public static int bwytrzymalosc;
    public static int brefleks;
    public static int bgardapercent;
    public static int bkontrapercent;
    public static int bobrmin;
    public static int bobrmax;
    public static int blevel;


    public Inventory Inventory;
    public EquipmentPanel EquipmentPanel;
		[SerializeField] StatPanel statPanel;
    [SerializeField] ItemSaveManager itemSaveManager;


		private void Awake()
		{
			statPanel.SetStats(Siła, Zręczność, Wytrzymałość, Refleks, Zdrowie, Kodycja, GardaProcent, KontratakProcent, ObrażeniaMinimalne, ObrażeniaMaksymalne);
			statPanel.UpdateStatValues();

			Inventory.OnItemRightClickedEvent += EquipFromInventory;
			EquipmentPanel.OnItemRightClickedEvent += UnequipFromEquipPanel;


    }

    private void Start()
    {
        
        if (PlayerPrefs.GetInt("ContinueGame") == 1)
        {
            PlayerSaveScript data1 = PlayerSaving.LoadPlayer1();
            Poziom.BaseValue = data1.blevel;
            Siła.BaseValue = data1.bsiła;
            Zręczność.BaseValue = data1.bzręcznosc;
            Wytrzymałość.BaseValue = data1.bwytrzymalosc;
            Refleks.BaseValue = data1.brefleks;
            Zdrowie.BaseValue = data1.bcurrentHP;
            Kodycja.BaseValue = data1.bcurrentKon;
            GardaProcent.BaseValue = data1.bgrada;
            KontratakProcent.BaseValue = data1.bkontratak;
            ObrażeniaMinimalne.BaseValue = data1.bobrazeniaMin;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
            currentHealth = data1.bcurrentHP;
            currentKon = data1.bcurrentKon;
        }
        else
        {
            Poziom.BaseValue = 1;
            Siła.BaseValue = 10;
            Zręczność.BaseValue = 10;
            Wytrzymałość.BaseValue = 10;
            Refleks.BaseValue = 10;
            Zdrowie.BaseValue = 100;
            Kodycja.BaseValue = 100;
            GardaProcent.BaseValue = 30;
            KontratakProcent.BaseValue = 25;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }

        itemSaveManager.LoadEquipment(this);
        itemSaveManager.LoadInventory(this);
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("levelup") == 1) 
        {
            LevelUP();
            PlayerPrefs.DeleteKey("levelup");
        }

       if (Poziom.BaseValue == 2)
        {
            Siła.BaseValue = 20;
            Zręczność.BaseValue = 20;
            Wytrzymałość.BaseValue = 15;
            Refleks.BaseValue = 15;
            Zdrowie.BaseValue = 120;
            Kodycja.BaseValue = 120;
            GardaProcent.BaseValue = 40;
            KontratakProcent.BaseValue = 30;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 3)
        {
            Siła.BaseValue = 30;
            Zręczność.BaseValue = 30;
            Wytrzymałość.BaseValue = 20;
            Refleks.BaseValue = 20;
            Zdrowie.BaseValue = 140;
            Kodycja.BaseValue = 140;
            GardaProcent.BaseValue = 50;
            KontratakProcent.BaseValue = 35;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 4)
        {
            Siła.BaseValue = 40;
            Zręczność.BaseValue = 40;
            Wytrzymałość.BaseValue = 25;
            Refleks.BaseValue = 25;
            Zdrowie.BaseValue = 160;
            Kodycja.BaseValue = 160;
            GardaProcent.BaseValue = 60;
            KontratakProcent.BaseValue = 40;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 5)
        {
            Siła.BaseValue = 50;
            Zręczność.BaseValue = 50;
            Wytrzymałość.BaseValue = 30;
            Refleks.BaseValue = 30;
            Zdrowie.BaseValue = 180;
            Kodycja.BaseValue = 180;
            GardaProcent.BaseValue = 70;
            KontratakProcent.BaseValue = 45;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 6)
        {
            Siła.BaseValue = 60;
            Zręczność.BaseValue = 60;
            Wytrzymałość.BaseValue = 35;
            Refleks.BaseValue = 35;
            Zdrowie.BaseValue = 200;
            Kodycja.BaseValue = 200;
            GardaProcent.BaseValue = 80;
            KontratakProcent.BaseValue = 50;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }
        if (Poziom.BaseValue == 7)
        {
            Siła.BaseValue = 70;
            Zręczność.BaseValue = 70;
            Wytrzymałość.BaseValue = 40;
            Refleks.BaseValue = 40;
            Zdrowie.BaseValue = 220;
            Kodycja.BaseValue = 220;
            GardaProcent.BaseValue = 90;
            KontratakProcent.BaseValue = 55;
            ObrażeniaMinimalne.BaseValue = 1;
            ObrażeniaMaksymalne.BaseValue = ObrażeniaMinimalne.BaseValue;
        }


        sila = (int)Siła.Value;
        zrecznosc = (int)Zręczność.Value;
        wytrzymalosc = (int)Wytrzymałość.Value;
        refleks = (int)Refleks.Value;
        gardapercent = (int)GardaProcent.Value;
        kontrapercent = (int)KontratakProcent.Value;
        obrmin = (int)ObrażeniaMinimalne.Value;
        obrmax = (int)ObrażeniaMaksymalne.Value;
        level = (int)Poziom.BaseValue;
        currentHealth = Zdrowie.Value;
        maxHealth = Zdrowie.Value;
        currentKon = Kodycja.Value;
        maxKon = Kodycja.Value;

        bsila = (int)Siła.BaseValue;
        bzrecznosc = (int)Zręczność.BaseValue;
        bwytrzymalosc = (int)Wytrzymałość.BaseValue;
        brefleks = (int)Refleks.BaseValue;
        bgardapercent = (int)GardaProcent.BaseValue;
        bkontrapercent = (int)KontratakProcent.BaseValue;
        bobrmin = (int)ObrażeniaMinimalne.BaseValue;
        bobrmax = (int)ObrażeniaMaksymalne.BaseValue;
        blevel = (int)Poziom.BaseValue;

    }

    private void OnDestroy()
    {
        itemSaveManager.SaveEquipment(this);
        itemSaveManager.SaveInventory(this);
    }

    public void LevelUP()
    {
        Poziom.BaseValue++;
    }


    public void SavePlayer1()
    {
        PlayerSaving.SavePlayer1(this);
    }

    public void LoadPlayer1()
    {
        PlayerSaveScript data1 = PlayerSaving.LoadPlayer1();
        sila = data1.bsiła;
        zrecznosc = data1.bzręcznosc;
        wytrzymalosc = data1.bwytrzymalosc;
        refleks = data1.brefleks;
        gardapercent = data1.bgrada;
        kontrapercent = data1.bkontratak;
        obrmin = data1.bobrazeniaMin;
        obrmax = data1.bobrazeniaMax;
        level = data1.blevel;
    }

    private void EquipFromInventory(Item item)
		{
			if (item is EquippableItem)
			{
				Equip((EquippableItem)item);
			}
		}

		private void UnequipFromEquipPanel(Item item)
		{
			if (item is EquippableItem)
			{
				Unequip((EquippableItem)item);
			}
		}

		public void Equip(EquippableItem item)
		{
			if (Inventory.RemoveItem(item))
			{
				EquippableItem previousItem;
				if (EquipmentPanel.AddItem(item, out previousItem))
				{
					if (previousItem != null)
					{
						Inventory.AddItem(previousItem);
						previousItem.Unequip(this);
						statPanel.UpdateStatValues();
					}
					item.Equip(this);
					statPanel.UpdateStatValues();
				}
				else
				{
					Inventory.AddItem(item);
				}
			}
		}

		public void Unequip(EquippableItem item)
		{
			if (!Inventory.IsFull() && EquipmentPanel.RemoveItem(item))
			{
				item.Unequip(this);
				statPanel.UpdateStatValues();
				Inventory.AddItem(item);
			}
		}
}
*/
