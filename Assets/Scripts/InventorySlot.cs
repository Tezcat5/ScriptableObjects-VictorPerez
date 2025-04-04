using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;
    public int slotNumber;
    public GameObject inspectionWindow;
    public Image inspectionImage;
    public Text inspectionName;
    public Text inspectionDescription;
    public Button closeButton;
    public Button deleteButton;

    // Start is called before the first frame update
    void Start()
    {
        Button thisButton = GetComponentInChildren<Button>();
        thisButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null && !inspectionWindow.activeInHierarchy)
        {
            
            deleteButton.onClick.AddListener(RemoveItem);
            closeButton.onClick.AddListener(CloseWindow);

            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionDescription.text = slotItem.itemDescription;


            inspectionWindow.SetActive(true);
        }
    }

    void RemoveItem()
    {
        if(InventoryManager.instance.weapons[slotNumber] != null)
        {
            InventoryManager.instance.weapons[slotNumber] = null;
            InventoryManager.instance.weaponsNames[slotNumber].text ="Empty";
            InventoryManager.instance.weaponsSprites[slotNumber].sprite = null;
        }

        CloseWindow();
    }

    void CloseWindow()
    {
        deleteButton.onClick.RemoveListener(RemoveItem);
        inspectionWindow.SetActive(false);
    }
}
