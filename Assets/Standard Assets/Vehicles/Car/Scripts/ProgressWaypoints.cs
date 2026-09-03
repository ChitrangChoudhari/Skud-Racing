using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    //public bool PenaltyOption = false;
    //public int PenaltyWayPoint;
    public int Position = 0;

    private int Lap1Position = 0;
    private int Lap2Position = 0;
    private int Lap3Position = 0;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                
                if(SaveScript.LapNumber == 1)
                {
                    Lap1Position++;
                    SaveScript.PlayerPosition = Lap1Position;
                   
                }
                if (SaveScript.LapNumber == 2)
                {
                    Lap2Position++;
                    SaveScript.PlayerPosition = Lap2Position;

                }
                if (SaveScript.LapNumber == 3)
                {
                    Lap3Position++;
                    SaveScript.PlayerPosition = Lap3Position;

                }
               

            }
            if(CarTracking > WPNumber)
            {
               
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
              
            }
            /*if(PenaltyOption == true)
            {
                if(CarTracking < PenaltyWayPoint)
                {
                    Debug.Log("Penalty");
                }
            }*/
        }


        if (other.gameObject.CompareTag("ProgressAIBlackCar"))
        {
            if(SaveScript.AICarBlackLapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICarBlackLapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICarBlackLapNumber == 3)
            {
                Lap3Position++;
            }
        }


        if (other.gameObject.CompareTag("ProgressAIBlueCar"))
        {
            if (SaveScript.AICarBlueLapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICarBlueLapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICarBlueLapNumber == 3)
            {
                Lap3Position++;
            }
        }
        if (other.gameObject.CompareTag("ProgressAIRedCar"))
        {
            if (SaveScript.AICarRedLapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICarRedLapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICarRedLapNumber == 3)
            {
                Lap3Position++;
            }
        }
        if (other.gameObject.CompareTag("ProgressAIYellowCar"))
        {
            if (SaveScript.AICarYellowLapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICarYellowLapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICarYellowLapNumber == 3)
            {
                Lap3Position++;
            }
        }
    }
}
