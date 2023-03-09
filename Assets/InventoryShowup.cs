using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryShowup : MonoBehaviour
{
    public static bool InventoryIsShowed = false;

    public GameObject InventoryUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (InventoryIsShowed == false)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }
    }

    public void Show()
    {
        InventoryUI.SetActive(true);
        InventoryIsShowed = true;
    }

    public void Hide()
    {
        InventoryUI.SetActive(false);
        InventoryIsShowed = false;
    }
}
