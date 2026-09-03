using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public Text SpeedText;
    public Text GearText;
    public Text LapNumberText;
    public Text TotalLapsText;
   
    public Text CheckPointTime;
    public Text WrongWayT;
    public Text TotalCarsText;
    public Text PlayersPosition;


    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText;
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;



    public GameObject CheckPointDisplay;
    public GameObject NewLapRecord;
    public GameObject WrongWayText;

   

    public float DisplaySpeed;
    private int TotalLaps = 3;
    private int TotalCars = 1;

    public bool RaceTrack = true;

    public GameObject QuitPanel;
 

    public GameObject OpponentBlack;
    public GameObject OpponentBlue;
    public GameObject OpponentRed;
    public GameObject OpponentYellow;

   

    
    void Start()
    {
        TotalLaps = UniversalSave.LapCounts;
        TotalCars = UniversalSave.OpponentsCount + 1;
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = "/" + TotalLaps.ToString();
        CheckPointDisplay.SetActive(false);
        NewLapRecord.SetActive(false);
        WrongWayText.SetActive(false);
        SaveScript.MaxLaps = TotalLaps;
        TotalCarsText.text = "/" + TotalCars.ToString();
        PlayersPosition.text = "1";
        QuitPanel.SetActive(false);

        if (RaceTrack == true) 
        { 
            SetCarVisibility(); 
        }

        
        
    }

    void SetCarVisibility()
    {
        if (TotalCars == 1)
        {
            OpponentBlack.SetActive(false);
            OpponentBlue.SetActive(false);
            OpponentRed.SetActive(false);
            OpponentYellow.SetActive(false);
        }
        if (TotalCars == 2)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(false);
            OpponentRed.SetActive(false);
            OpponentYellow.SetActive(false);
        }
        if (TotalCars == 3)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(true);
            OpponentRed.SetActive(false);
            OpponentYellow.SetActive(false);
        }
        if (TotalCars == 4)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(true);
            OpponentRed.SetActive(true);
            OpponentYellow.SetActive(false);
        }
        if (TotalCars == 5)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(true);
            OpponentRed.SetActive(true);
            OpponentYellow.SetActive(true);
        }
        if (TotalCars == 6)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(true);
            OpponentRed.SetActive(true);
            OpponentYellow.SetActive(true);
        }
        if (TotalCars == 7)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(true);
            OpponentRed.SetActive(true);
            OpponentYellow.SetActive(true);
        }
        if (TotalCars == 8)
        {
            OpponentBlack.SetActive(true);
            OpponentBlue.SetActive(true);
            OpponentRed.SetActive(true);
            OpponentYellow.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Speedometer
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString());
        GearText.text = (SaveScript.Gear + 1).ToString();
        
        //LapNumber
        LapNumberText.text = SaveScript.LapNumber.ToString();

        //LapTime
        if(SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        if (SaveScript.LapTimeSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }
        else if (SaveScript.LapTimeSeconds >= 10)
        {
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }

        //RaceTime
        if (SaveScript.RaceTimeMinutes <= 9)
        {
            RaceTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.LapTimeMinutes >= 10)
        {
            RaceTimeMinutesText.text = (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }
        if (SaveScript.RaceTimeSeconds <= 9)
        {
            RaceTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }
        else if (SaveScript.RaceTimeSeconds >= 10)
        {
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        //Best LapTime
        if (SaveScript.LapChange == true) {
            if (SaveScript.LastLapM == SaveScript.BestLapTimeM)
            {
                if (SaveScript.LastLapS < SaveScript.BestLapTimeS)
                {
                    SaveScript.BestLapTimeS = SaveScript.LastLapS;
                    SaveScript.NewRecord = true;
                }
            }

            if (SaveScript.LastLapM < SaveScript.BestLapTimeM)
            {
                SaveScript.BestLapTimeM = SaveScript.LastLapM;
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
                SaveScript.NewRecord = true;
            }
        }
        

        //BestLapTimeDisplay
        if (SaveScript.BestLapTimeM <= 9)
        {
            BestLapTimeMinutes.text = "0" + (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }
        else if (SaveScript.BestLapTimeM >= 10)
        {
            BestLapTimeMinutes.text = (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }
        if (SaveScript.BestLapTimeS <= 9)
        {
            BestLapTimeSeconds.text = "0" + (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }
        else if (SaveScript.BestLapTimeS >= 10)
        {
            BestLapTimeSeconds.text = (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }

        if(SaveScript.NewRecord == true)
        {
            NewLapRecord.SetActive(true);
            StartCoroutine(LapRecordOff());

        }

        //Checkpoint 1
        if(SaveScript.CheckPointPass1 == true)
        {
            SaveScript.CheckPointPass1 = false;
            if (SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if (SaveScript.ThisCheckPoint1 > SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint1 - SaveScript.LastCheckPoint1).ToString();
                    StartCoroutine(CheckPointOff());
                }
                if (SaveScript.ThisCheckPoint1 < SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = "+" + (SaveScript.LastCheckPoint1 - SaveScript.ThisCheckPoint1).ToString();
                    StartCoroutine(CheckPointOff());
                }
            }
           
        }

        //Checkpoint 2
        if (SaveScript.CheckPointPass2 == true)
        {
            SaveScript.CheckPointPass2 = false;
            if (SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if (SaveScript.ThisCheckPoint2 > SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint2 - SaveScript.LastCheckPoint2).ToString();
                    StartCoroutine(CheckPointOff());
                }
                if (SaveScript.ThisCheckPoint2 < SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = "+" + (SaveScript.LastCheckPoint2 - SaveScript.ThisCheckPoint2).ToString();
                    StartCoroutine(CheckPointOff());
                }

            }
        }
        if(SaveScript.WrongWay == true)
        {
            WrongWayText.SetActive(true);
        }
        if (SaveScript.WrongWay == false)
        {
            WrongWayText.SetActive(false);
        }

        //wrong way reset text
        if(SaveScript.WWTextReset == false)
        {
            WrongWayT.text = "Wrong Way!";
        }
        if (SaveScript.WWTextReset == true)
        {
            WrongWayT.text = " ";
        }

        PlayersPosition.text = SaveScript.PlayerPosition.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    
    }
    IEnumerator CheckPointOff()
    {
        yield return new WaitForSeconds(2);
        CheckPointDisplay.SetActive(false);
    }

    IEnumerator LapRecordOff()
    {
        yield return new WaitForSeconds(2);
        SaveScript.NewRecord = false;
        NewLapRecord.SetActive(false);
    }

    public void ContinueButtonFunction()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    public void QuitClose()
    {
        Time.timeScale = 1.0f;
        QuitPanel.SetActive(false);
    }

    
    
   
}
