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

    public List<Software> items = new List<Software>();

    public bool AddItem(Software software)
    {
        if (!software.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not Enough space");
                return false;
            }
            items.Add(software);

            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }

        }

        return true;
    }

    public void RemoveItem(Software software)
    {
        items.Remove(software);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

}
