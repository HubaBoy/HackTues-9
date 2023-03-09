using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;

    public List<SoftwareScripts> items = new List<SoftwareScripts>();

    public bool AddItem(SoftwareScripts softwareScripts)
    {
        if (!softwareScripts.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not Enough space");
                return false;
            }
            items.Add(softwareScripts);

            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }

        }

        return true;
    }

    public void RemoveItem(SoftwareScripts softwareScripts)
    {
        items.Remove(softwareScripts);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

}
