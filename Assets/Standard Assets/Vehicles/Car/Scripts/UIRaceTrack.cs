using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRaceTrack : MonoBehaviour
{
    public Text WinMessage;
    public GameObject Leaderboard;
    public Text Cash;
    public int FirstPlaceCash = 3000;
    public int SecondPlaceCash = 2000;
    public int ThirdPlaceCash = 1000;
    void Start()
    {
        Leaderboard.SetActive(false);

        if(UniversalSave.OpponentsCount > 0)
        {
            FirstPlaceCash *= UniversalSave.OpponentsCount;
            SecondPlaceCash *= UniversalSave.OpponentsCount;
            ThirdPlaceCash += UniversalSave.OpponentsCount;
        }
        if(FinishLine.PlayerFinishPosition == 1)
        {
            WinMessage.text = "1ST PLACE";
            Cash.text = FirstPlaceCash.ToString();
            UniversalSave.CashAmount = UniversalSave.CashAmount += FirstPlaceCash;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 2)
        {
            WinMessage.text = "2ND PLACE";
            Cash.text = SecondPlaceCash.ToString();
            UniversalSave.CashAmount = UniversalSave.CashAmount += SecondPlaceCash;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 3)
        {
            WinMessage.text = "3RD PLACE";
            Cash.text = ThirdPlaceCash.ToString();
            UniversalSave.CashAmount = UniversalSave.CashAmount += ThirdPlaceCash;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 4)
        {
            WinMessage.text = "4TH PLACE";
            Cash.text = "0";
            UniversalSave.RacesLost++;
        }
        if (FinishLine.PlayerFinishPosition == 5)
        {
            WinMessage.text = "5TH PLACE";
            Cash.text = "0";
            UniversalSave.RacesLost++;
        }

        UniversalSave.Saving = true;
    }

    public void DisplayLeaderboard()
    {
        Leaderboard.SetActive(true);
        this.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    // Update is called once per frame
    
}
