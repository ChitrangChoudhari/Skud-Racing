using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardDisplay : MonoBehaviour
{
    public Text Position;
    public Text Name;
    public Text Minutes;
    public Text Seconds;

    public bool AIBlack;
    public bool AIBlue;
    public bool AIRed;
    public bool AIYellow;
    public bool Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //black car
        if (AIBlack == true)
        {
            Position.text = FinishLineAI.AICarBlackFinishPosition.ToString();
            Name.text = FinishLineAI.AICarBlackName;
           
            if(FinishLineAI.AICarBlackMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICarBlackMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICarBlackMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICarBlackMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICarBlackSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICarBlackSeconds).ToString();
            }
            if (FinishLineAI.AICarBlackSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICarBlackSeconds).ToString();
            }
        }


        //blue car
        if (AIBlue == true)
        {
            Position.text = FinishLineAI.AICarBlueFinishPosition.ToString();
            Name.text = FinishLineAI.AICarBlueName;

            if (FinishLineAI.AICarBlueMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICarBlueMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICarBlueMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICarBlueMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICarBlueSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICarBlueSeconds).ToString();
            }
            if (FinishLineAI.AICarBlueSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICarBlueSeconds).ToString();
            }
        }

        //red car
        if (AIRed == true)
        {
            Position.text = FinishLineAI.AICarRedFinishPosition.ToString();
            Name.text = FinishLineAI.AICarRedName;

            if (FinishLineAI.AICarRedMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICarRedMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICarRedMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICarRedMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICarRedSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICarRedSeconds).ToString();
            }
            if (FinishLineAI.AICarRedSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICarRedSeconds).ToString();
            }
        }

        //yellow car
        if (AIYellow == true)
        {
            Position.text = FinishLineAI.AICarYellowFinishPosition.ToString();
            Name.text = FinishLineAI.AICarYellowName;

            if (FinishLineAI.AICarYellowMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICarYellowMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICarYellowMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICarYellowMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICarYellowSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICarYellowSeconds).ToString();
            }
            if (FinishLineAI.AICarYellowSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICarYellowSeconds).ToString();
            }
        }

        //player car
        if (Player == true)
        {
            Position.text = FinishLine.PlayerFinishPosition.ToString();
            Name.text = FinishLine.PName;

            if (SaveScript.RaceTimeMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(SaveScript.RaceTimeMinutes).ToString() + ":";
            }
            if (SaveScript.RaceTimeMinutes >= 10)
            {
                Minutes.text = Mathf.Round(SaveScript.RaceTimeMinutes).ToString() + ":";
            }

            if (SaveScript.RaceTimeSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(SaveScript.RaceTimeSeconds).ToString();
            }
            if (SaveScript.RaceTimeSeconds >= 10)
            {
                Seconds.text = Mathf.Round(SaveScript.RaceTimeSeconds).ToString();
            }
        }
    }
}
