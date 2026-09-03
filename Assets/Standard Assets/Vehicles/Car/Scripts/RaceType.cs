using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceType : MonoBehaviour
{
    public bool TimeTrial = true;
    public float GoldMinutes;
    public float GoldSeconds;
    public float SilverMinutes;
    public float SilverSeconds;
    public float BronzeMinutes;
    public float BronzeSeconds;
    

    void Start()
    {
        if(TimeTrial == true)
        {
            SaveScript.TimeTrialMinG = GoldMinutes;
            SaveScript.TimeTrialSecondsG = GoldSeconds;
            SaveScript.TimeTrialMinS = SilverMinutes;
            SaveScript.TimeTrialSecondsS = SilverSeconds;
            SaveScript.TimeTrialMinB = BronzeMinutes;
            SaveScript.TimeTrialSecondsB = BronzeSeconds;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SaveScript.RaceOver == true)
        {
            if(TimeTrial == true)
            {
                // Gold minutes
                if (SaveScript.RaceTimeMinutes < GoldMinutes)
                {
                    
                    SaveScript.Gold = true;
                }
                if (SaveScript.RaceTimeMinutes == GoldMinutes && SaveScript.RaceTimeSeconds < GoldSeconds)
                {
                  
                    SaveScript.Gold = true;
                }
                // silver minutes
                if (SaveScript.RaceTimeMinutes < SilverMinutes)
                {
                    if (SaveScript.Gold == false)
                    {
                      
                        SaveScript.Silver = true;
                    }
                }
                if (SaveScript.RaceTimeMinutes == SilverMinutes && SaveScript.RaceTimeSeconds < SilverSeconds)
                {
                    if (SaveScript.Gold == false)
                    {
                       
                        SaveScript.Silver = true;
                    }
                }

                // Bronze minutes
                if (SaveScript.RaceTimeMinutes < BronzeMinutes)
                {
                    if (SaveScript.Gold == false && SaveScript.Silver == false)
                    {
                       
                        SaveScript.Bronze = true;
                    }
                }
                if (SaveScript.RaceTimeMinutes == BronzeMinutes && SaveScript.RaceTimeSeconds < BronzeSeconds)
                {
                    if (SaveScript.Gold == false && SaveScript.Silver == false)
                    {
                       
                        SaveScript.Bronze = true;
                    }
                }
                //for Fail
               
                  else if (SaveScript.Gold == false && SaveScript.Silver == false && SaveScript.Bronze ==false)
                    {
                  
                        SaveScript.Fail = true;
                    }
                
            }
        }
    }

   
  
}
