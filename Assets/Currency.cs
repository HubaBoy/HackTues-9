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
        if (instance == null)
        {
            instance = this; // In first scene, make us the singleton.
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject); // On reload, singleton already set, so destroy duplicate.
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
