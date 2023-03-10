using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SyberAttack : MonoBehaviour
{
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

    public GameObject Warning;
    static SyberAttack instance;
    public bool isUnderSyberAttack = false;
    public float chanceToBeOnThatPC = 1;
    public bool canBeHackedOnThatPC;
    public bool isHacked = false;

    public Transform gameObjToHack;


    public float timeUntillNextAttack;


    void Start()
    {
        timeUntillNextAttack = Random.Range(10, 30);
    }

    void Update()
    {
        if(timeUntillNextAttack > 0)
        {
            timeUntillNextAttack -= Time.deltaTime;
        }
        else
        {
            isUnderSyberAttack = true;
        }

        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            canBeHackedOnThatPC = true;
        }

        if(isUnderSyberAttack && SceneManager.GetActiveScene().name != "SampleScene" && canBeHackedOnThatPC && !isHacked)
        {
            if(chanceToBeOnThatPC == 0)
            {
                MalwareAttack();
                isHacked = true;
            }
            else
            {
                chanceToBeOnThatPC -= 1;
            }
            canBeHackedOnThatPC = false;
        }

        if (isUnderSyberAttack)
        {
            Warning.SetActive(true);
        }
    }

    public void MalwareAttack()
    {
        gameObjToHack = GameObject.Find("Canvas/FileExplorer/FileParent").transform;
        gameObjToHack.GetComponent<FileParrent>().isBeingHacked = true;
        foreach(Transform children in gameObjToHack)
        {
            if(Random.Range(1,3) % 2 == 0)
            {
                children.GetComponent<FileFunctions>().isSus = true;
                gameObjToHack.GetComponent<FileParrent>().numberOfCoruptedFiles += 1;
            }
        }
    }
}
