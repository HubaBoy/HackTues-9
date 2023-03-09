using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomTaskBar : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Files;

    public void ActivateProgram(string name)
    {
        if(name == "Shop")
        {
            Shop.SetActive(true);
            Files.SetActive(false);
        }else if (name == "Files")
        {
            Shop.SetActive(false);
            Files.SetActive(true);
        }else if(name == "Exit")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
