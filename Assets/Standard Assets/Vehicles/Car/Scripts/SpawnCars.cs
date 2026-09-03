using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject SportsCar1;
    public GameObject SportsCar2;
    public Transform SpawnPoint;
    void Start()
    {
        if(SaveScript.SportsCarID == 1)
        {
            Instantiate(SportsCar1, SpawnPoint.position, SpawnPoint.rotation);
        }
        if (SaveScript.SportsCarID == 2)
        {
            Instantiate(SportsCar2, SpawnPoint.position, SpawnPoint.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
