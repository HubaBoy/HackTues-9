using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    public Text moneyText;
    public float moneyAmount;
    
    public GameObject AmountOfMoney;
    
    void Start()
    {
        moneyText.text = "Money:" + moneyAmount;
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            AmountOfMoney.SetActive(false);
        }
        else
        {
            AmountOfMoney.SetActive(true);
        }
        moneyText.text = "Money:" + moneyAmount;
    }

    public void AddMoney(float amount)
    {
        moneyAmount += amount;
    }

    public void WithDraw(float amount)
    {
        moneyAmount -= amount;
    }
}
