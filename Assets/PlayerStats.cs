using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;

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

    public float DetectionSoftwarePower;
    public float AntiMalwareSoftwarePower;
    public float AntiSQLSoftwarePower;
    public float BandwithPower;
    public float FireWallPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EquipAndModifyStats(Software software)
    {
        DetectionSoftwarePower += software.DetectionSoftwarePower;
        AntiMalwareSoftwarePower += software.AntiMalwareSoftwarePower;
        AntiSQLSoftwarePower += software.AntiSQLSoftwarePower;
        BandwithPower += software.BandwithPower;
        FireWallPower += software.FireWallPower;
    }
}
