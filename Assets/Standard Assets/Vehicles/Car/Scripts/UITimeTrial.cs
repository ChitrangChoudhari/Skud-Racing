using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITimeTrial : MonoBehaviour
{

    public Text TimeTrialMinutesG;
    public Text TimeTrialMinutesS;
    public Text TimeTrialMinutesB;
    public Text TimeTrialSecondsG;
    public Text TimeTrialSecondsS;
    public Text TimeTrialSecondsB;

    public Text WinMessage;
    public Text Cash;

    public GameObject GoldMedal;
    public GameObject SilverMedal;
    public GameObject BronzeMedal;
    public GameObject FailMedal;
    public GameObject TimeTrialObject;
    public GameObject TimeTrialResults;

    public int GoldCash = 3000;
    public int SilverCash = 2000;
    public int BronzeCash = 1000;

    private bool winner = false;
    void Start()
    {
        TimeTrialObject.SetActive(true);
        TimeTrialResults.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //Setting Timetrial Gold

        if (SaveScript.TimeTrialMinG <= 9)
        {
            TimeTrialMinutesG.text = "0" + SaveScript.TimeTrialMinG.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinG >= 10)
        {
            TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString() + ":";
        }

        if (SaveScript.TimeTrialSecondsG <= 9)
        {
            TimeTrialSecondsG.text = "0" + SaveScript.TimeTrialSecondsG.ToString();
        }
        if (SaveScript.TimeTrialMinG >= 10)
        {
            TimeTrialSecondsG.text = SaveScript.TimeTrialSecondsG.ToString();
        }

        //Setting Timetrial Silver

        if (SaveScript.TimeTrialMinS <= 9)
        {
            TimeTrialMinutesS.text = "0" + SaveScript.TimeTrialMinS.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinS >= 10)
        {
            TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString() + ":";
        }

        if (SaveScript.TimeTrialSecondsS <= 9)
        {
            TimeTrialSecondsS.text = "0" + SaveScript.TimeTrialSecondsS.ToString();
        }
        if (SaveScript.TimeTrialMinS >= 10)
        {
            TimeTrialSecondsS.text = SaveScript.TimeTrialSecondsS.ToString();
        }

        //Setting Timetrial bronze

        if (SaveScript.TimeTrialMinB <= 9)
        {
            TimeTrialMinutesB.text = "0" + SaveScript.TimeTrialMinB.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinB >= 10)
        {
            TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString() + ":";
        }

        if (SaveScript.TimeTrialSecondsB <= 9)
        {
            TimeTrialSecondsB.text = "0" + SaveScript.TimeTrialSecondsB.ToString();
        }
        if (SaveScript.TimeTrialMinB >= 10)
        {
            TimeTrialSecondsB.text = SaveScript.TimeTrialSecondsB.ToString();
        }

        if(SaveScript.RaceOver == true)
        {
            if(winner == false)
            {
                winner = true;
                StartCoroutine(WinDisplay());
            }
        }
    }


    IEnumerator WinDisplay()
    {
        yield return new WaitForSeconds(0.15f);
        TimeTrialResults.SetActive(true);

        if (SaveScript.Gold == true)
        {
            WinMessage.text = "GOLD";
            GoldMedal.SetActive(true);
            Cash.text = GoldCash.ToString();
            UniversalSave.CashAmount = UniversalSave.CashAmount += GoldCash;
            UniversalSave.RacesWon++;

        }

        if (SaveScript.Silver == true)
        {
            WinMessage.text = "Silver";
            SilverMedal.SetActive(true);
            Cash.text = SilverCash.ToString();
            UniversalSave.CashAmount = UniversalSave.CashAmount += SilverCash;
            UniversalSave.RacesWon++;

        }
        if (SaveScript.Bronze == true)
        {
            WinMessage.text = "Bronze";
            BronzeMedal.SetActive(true);
            Cash.text = BronzeCash.ToString();
            UniversalSave.CashAmount = UniversalSave.CashAmount += BronzeCash;
            UniversalSave.RacesWon++;

        }
        if (SaveScript.Fail == true)
        {
            WinMessage.text = "Try Again";
            Cash.text = "0";
            UniversalSave.RacesLost++;


        }

        UniversalSave.Saving = true;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(1);   
    }
}
