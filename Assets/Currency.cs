using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Currency : MonoBehaviour
{
    public static Currency instance;

    public static float money = 0;

    public void AddMoney(float amount)
    {
        money += amount;
    }

    public void WithDraw(float amount)
    {
        money -= amount;
    }
}
