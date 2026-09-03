using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public Text Mode;
    public Text LapCount;
    public Text OpponentCount;
    private bool TimeTrial = true;
    public int CurrentLapCount = 1;
    private int CurrentOpponentCount = 1;
    public int TimeTrialSceneNumber;
    public int RaceTrackSceneNumber;
    

    public GameObject LoadScreen;
    public GameObject OpponentPanelOn;
    public GameObject LapsOn;
    public void ModeNext()
    {
        if (TimeTrial == true)
        {
            Mode.text= "Race";
            TimeTrial = false;
            OpponentPanelOn.SetActive(true);
            LapsOn.SetActive(true);
        }
    }

    public void ModeBack()
    {
        if (TimeTrial == false)
        {
            Mode.text = "Time Trial";
            TimeTrial = true;
            OpponentPanelOn.SetActive(false);
            LapsOn.SetActive(false);
        }
    }

    public void LapCountNext()
    {
        if(CurrentLapCount < 12)
        {
            CurrentLapCount++;
            LapCount.text = CurrentLapCount + " Laps";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void LapCountBack()
    {
        if (CurrentLapCount > 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " Laps";
            UniversalSave.LapCounts = CurrentLapCount;
        }
      else if (CurrentLapCount == 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " Lap";
            UniversalSave.LapCounts = CurrentLapCount;
        }

    }

    public void OpponentsNext()
    {
        if(CurrentOpponentCount < 7)
        {
            CurrentOpponentCount++;
            OpponentCount.text = CurrentOpponentCount + " Opponents";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }
    public void OpponentsBack()
    {
        if (CurrentOpponentCount > 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " Opponents";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
        else if (CurrentOpponentCount == 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " Opponent";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }

    public void BeginRace()
    {
        if(TimeTrial == true)
        {
           
            StartCoroutine(WaitToLoad());
        }
        if (TimeTrial == false)
        {
           
            StartCoroutine(WaitToLoad2());
        }




        void ResetValues()
        {
            Time.timeScale = 1.0f;
            SaveScript.LapNumber = 0;
            SaveScript.LapChange = false;
            SaveScript.LapTimeMinutes = 0.0f;
            SaveScript.LapTimeSeconds = 0.0f;
            SaveScript.RaceTimeMinutes = 0.0f;
            SaveScript.RaceTimeSeconds = 0.0f;
            SaveScript.LastLapM = 0.0f;
            SaveScript.LastLapS = 0.0f;
            SaveScript.GameTime = 0.0f;
            SaveScript.LastCheckPoint1 = 0.0f;
            SaveScript.LastCheckPoint2 = 0.0f;
            SaveScript.ThisCheckPoint1 = 0.0f;
            SaveScript.ThisCheckPoint2 = 0.0f;
            SaveScript.CheckPointPass1 = false;
            SaveScript.CheckPointPass2 = false;
            SaveScript.HalfWayActivated = true;
            SaveScript.RaceOver = false;
            SaveScript.RaceStart = false;
            SaveScript.PlayerPosition = 0;
            SaveScript.Gold = false;
            SaveScript.Silver = false;
            SaveScript.Bronze = false;
            SaveScript.Fail = false;
            SaveScript.AICarBlackLapNumber = 0;
            SaveScript.AICarBlueLapNumber = 0;
            SaveScript.AICarRedLapNumber = 0;
            SaveScript.AICarYellowLapNumber = 0;
            SaveScript.FinishPositionID = 0;

        }



        IEnumerator WaitToLoad()
        {
            ResetValues();
            yield return new WaitForSeconds(.1f);
            LoadScreen.SetActive(true);
            UniversalSave.LapCounts = 1;
            UniversalSave.OpponentsCount = 0;
            SceneManager.LoadScene(TimeTrialSceneNumber);
        }
        IEnumerator WaitToLoad2()
        {
            ResetValues();
            yield return new WaitForSeconds(.1f);
            LoadScreen.SetActive(true);
            UniversalSave.LapCounts = CurrentLapCount;
            UniversalSave.OpponentsCount = CurrentOpponentCount;
            SceneManager.LoadScene(RaceTrackSceneNumber);
        }
    }
}
