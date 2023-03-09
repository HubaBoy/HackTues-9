using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;

    public GameObject infoShowup;

    public InfoShowup InfoShowup;
    public Software software;

    Software Software;

    public void AddItem(Software softwares)
    {
        software = softwares;

        icon.sprite = softwares.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        Software = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnButtonPress()
    {
        infoShowup.SetActive(true);
        infoShowup.transform.position = transform.position;
        InfoShowup.software = software;

    }

    public void OnRemoveButton()
    {
        Inventory.instance.RemoveItem(Software);
    }

    public void UseItem()
    {
        if (Software != null)
        {
            Software.Use();
        }
    }

}
