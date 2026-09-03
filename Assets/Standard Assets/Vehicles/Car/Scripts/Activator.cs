using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject FinishPoint;
    public GameObject FinishPointAIBlack;
    public GameObject FinishPointAIBlue;
    public GameObject FinishPointAIRed;
    public GameObject FinishPointAIYellow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Progress"))
        {
            SaveScript.HalfWayActivated = true;

            if(SaveScript.LapNumber == SaveScript.MaxLaps)
            {
                FinishPoint.SetActive(true);
            }
        }

        if (other.gameObject.CompareTag("ProgressAIBlackCar"))
        {
            SaveScript.HalfWayActivated = true;

            if (SaveScript.AICarBlackLapNumber == SaveScript.MaxLaps)
            {
                FinishPointAIBlack.SetActive(true);
            }
        }

        if (other.gameObject.CompareTag("ProgressAIBlueCar"))
        {
            SaveScript.HalfWayActivated = true;

            if (SaveScript.AICarBlueLapNumber == SaveScript.MaxLaps)
            {
                FinishPointAIBlue.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAIRedCar"))
        {
            SaveScript.HalfWayActivated = true;

            if (SaveScript.AICarRedLapNumber == SaveScript.MaxLaps)
            {
                FinishPointAIRed.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAIYellowCar"))
        {
            SaveScript.HalfWayActivated = true;

            if (SaveScript.AICarYellowLapNumber == SaveScript.MaxLaps)
            {
                FinishPointAIYellow.SetActive(true);
            }
        }
    }
}
