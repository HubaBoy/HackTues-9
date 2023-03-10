using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Currency : MonoBehaviour
{
    static Currency instance;

    void Awake()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("GameManager");
        if (gameObjects.Length > 1)
        {
            Destroy(gameObject);
        }
    }



    public static float money = 0;

    public void AddMoney(float amount)
    {
        money += amount;
    }

    public void WithDraw(float amount)
    {
      //  if(money>amount){
        //money -= amount;
       // }
    }
}
