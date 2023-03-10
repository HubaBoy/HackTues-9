using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public static Currency instance;

    private float money = 0;

    public void AddMoney(float amount)
    {
        money += amount;
    }

    public void WithDraw(float amount)
    {
        money -= amount;
    }
}
