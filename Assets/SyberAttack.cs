using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyberAttack : MonoBehaviour
{
    static SyberAttack instance;

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


    public float timeUntillNextAttack;


    void Start()
    {
        timeUntillNextAttack = Random.Range(100, 300);
    }

    void Update()
    {
        if(timeUntillNextAttack > 0)
        {
            timeUntillNextAttack -= Time.deltaTime;
        }
    }
}
