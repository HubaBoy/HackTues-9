using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoShowup : MonoBehaviour
{
    public static InfoShowup instance;

    public Software software;

    public string name;
    public string description;

    public Text itemName;
    public Text itemDescription;

    void Update()
    {
        itemName.text = name;
        itemDescription.text = description;
    }

    public void Equiping()
    {
        SoftwareManager.instance.Equip(software);
        transform.gameObject.SetActive(false);
        Inventory.instance.RemoveItem(software);
    }

    public void OnCloseButton()
    {
        transform.gameObject.SetActive(false);
    }
}
