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
        Debug.Log("Entering AddItem function");
        if (!software.isDefaultItem)
        {
            Debug.Log("In the if");

            if (items.Count >= space)
            {
                Debug.Log("In the if2");

                Debug.Log("Not Enough space");
                return false;
            }
            Debug.Log("Before Add ");

            items.Add(software);

            Debug.Log("After Add ");

            if (onItemChangedCallback != null)
            {
                Debug.Log("In if ");

                onItemChangedCallback.Invoke();
            }
            Debug.Log("Item Added ");
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
