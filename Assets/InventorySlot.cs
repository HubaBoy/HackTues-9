using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;

    public GameObject infoShowup;

    SoftwareScripts SoftwareScript;

    public void AddItem(SoftwareScripts newSoftwareScripts)
    {
        SoftwareScript = newSoftwareScripts;

        icon.sprite = SoftwareScript.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        SoftwareScript = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnButtonPress()
    {
        infoShowup.SetActive(true);
        infoShowup.transform.position = transform.position;
    }

    public void OnRemoveButton()
    {
        Inventory.instance.RemoveItem(SoftwareScript);
    }

    public void UseItem()
    {
        if (SoftwareScript != null)
        {
            SoftwareScript.Use();
        }
    }

}
