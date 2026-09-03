using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCars : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject SecondCar;
    public GameObject ThirdCar;
    public static int CarNumber = 1;
   
    public void NextCar()
    {
        if(CarNumber < 3)
        {
            CarNumber++;
        }
        DisplayCars();
    }

    public void LastCar()
    {
        if (CarNumber > 1)
        {
            CarNumber--;
        }
        DisplayCars();
    }

    void DisplayCars()
    {
        if(CarNumber == 1)
        {
            FirstCar.SetActive(true);
            SecondCar.SetActive(false);
            ThirdCar.SetActive(false);
        }
        if (CarNumber == 2)
        {
            FirstCar.SetActive(false);
            SecondCar.SetActive(true);
            ThirdCar.SetActive(false);
        }
        if (CarNumber == 3)
        {
            FirstCar.SetActive(false);
            SecondCar.SetActive(false);
            ThirdCar.SetActive(true);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
