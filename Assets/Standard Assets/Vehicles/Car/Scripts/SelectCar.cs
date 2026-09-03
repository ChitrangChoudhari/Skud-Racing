using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCar : MonoBehaviour
{
   public void ChooseCar()
    {
        SaveScript.SportsCarID = SelectCars.CarNumber;
        SaveScript.SupportsCarColor = SaveScript.PreviewCarColor;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
