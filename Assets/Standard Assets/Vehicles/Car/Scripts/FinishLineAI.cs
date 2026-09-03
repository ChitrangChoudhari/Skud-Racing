using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineAI : MonoBehaviour
{
    public bool AIBlack;
    public bool AIBlue;
    public bool AIRed;
    public bool AIYellow;
    public string CarName;

    //black car
    public static int AICarBlackFinishPosition;
    public static string AICarBlackName;
    public static float AICarBlackMinutes;
    public static float AICarBlackSeconds;
    //blue car
    public static int AICarBlueFinishPosition;
    public static string AICarBlueName;
    public static float AICarBlueMinutes;
    public static float AICarBlueSeconds;
    //red car
    public static int AICarRedFinishPosition;
    public static string AICarRedName;
    public static float AICarRedMinutes;
    public static float AICarRedSeconds;
    //yellow car
    public static int AICarYellowFinishPosition;
    public static string AICarYellowName;
    public static float AICarYellowMinutes;
    public static float AICarYellowSeconds;



    public void Start()
    {
        AICarBlackFinishPosition = 0;
        AICarBlackMinutes = 0;
        AICarBlackSeconds = 0;
        AICarBlueFinishPosition = 0;
        AICarBlueMinutes = 0;
        AICarBlueSeconds = 0;
        AICarRedFinishPosition = 0;
        AICarRedMinutes = 0;
        AICarRedSeconds = 0;
        AICarYellowFinishPosition = 0;
        AICarYellowMinutes = 0;
        AICarYellowSeconds = 0;

    }
    private void OnTriggerEnter(Collider other)
    {
        if(AIBlack == true) { 
        if (other.gameObject.CompareTag("ProgressAIBlackCar"))
        {
            SaveScript.FinishPositionID++;
            AICarBlackFinishPosition = SaveScript.FinishPositionID;
                AICarBlackName = CarName;
                AICarBlackMinutes = SaveScript.RaceTimeMinutes;
                AICarBlackSeconds = SaveScript.RaceTimeSeconds;
        }
        }

        if (AIBlue == true)
        {
            if (other.gameObject.CompareTag("ProgressAIBlueCar"))
            {
                SaveScript.FinishPositionID++;
                AICarBlueFinishPosition = SaveScript.FinishPositionID;
                AICarBlueName = CarName;
                AICarBlueMinutes = SaveScript.RaceTimeMinutes;
                AICarBlueSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AIRed == true)
        {
            if (other.gameObject.CompareTag("ProgressAIRedCar"))
            {
                SaveScript.FinishPositionID++;
                AICarRedFinishPosition = SaveScript.FinishPositionID;
                AICarRedName = CarName;
                AICarRedMinutes = SaveScript.RaceTimeMinutes;
                AICarRedSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AIYellow == true)
        {
            if (other.gameObject.CompareTag("ProgressAIYellowCar"))
            {
                SaveScript.FinishPositionID++;
                AICarYellowFinishPosition = SaveScript.FinishPositionID;
                AICarYellowName = CarName;
                AICarYellowMinutes = SaveScript.RaceTimeMinutes;
                AICarYellowSeconds = SaveScript.RaceTimeSeconds;
            }
        }
    }
}
