using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInfoShowup : MonoBehaviour
{
    public static itemInfoShowup instance;

    public Transform canvas;

    public GameObject itemInfoPrefab;
    public GameObject currentItemInfo = null;

    public void DisplayItemInfo(string itemName, string itemDescription, Vector2 buttonPos)
    {
        if(currentItemInfo != null)
        {
            Destroy(currentItemInfo.gameObject);
        }

        currentItemInfo = Instantiate(itemInfoPrefab, buttonPos, Quaternion.identity, canvas);
        currentItemInfo.GetComponent<ItemInfo>().SetUp(itemName, itemDescription);
    }

    public void DestroyItemInfo()
    {
        if(currentItemInfo != null)
        {
            Destroy(currentItemInfo.gameObject);
        }
    }
}
