using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTimeTrial : MonoBehaviour
{
   
   
    public static int PlayerFinishPosition;
   

    void Start()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.FinishPositionID++;
            PlayerFinishPosition = SaveScript.FinishPositionID;
            SaveScript.RaceOver = true;
            Time.timeScale = 0.2f;
          
        }

    }

}
