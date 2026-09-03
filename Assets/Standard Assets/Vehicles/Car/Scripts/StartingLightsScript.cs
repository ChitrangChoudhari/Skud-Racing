using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLightsScript : MonoBehaviour
{

   
    public GameObject RedLightOn;
    public GameObject OrangeLightOn;
    public GameObject GreenLightOn;

    public GameObject lightsBackground;
    public GameObject RedLightOff;
    public GameObject OrangeLightOff;
    public GameObject GreenLightOff;

    public GameObject Countone;
    public GameObject Counttwo;
    public GameObject Countthree;
    public GameObject GO;



    public AudioSource BeepSound1;
    public AudioSource BeepSound2;

    void Start()
    {
       
        RedLightOn.SetActive(false);
        OrangeLightOn.SetActive(false);
        GreenLightOn.SetActive(false);
        Countone.SetActive(false);
        Counttwo.SetActive(false);
        Countthree.SetActive(false);
        GO.SetActive(false);

        StartCoroutine(StartingLights());
    }

    IEnumerator StartingLights()
    {
        yield return new WaitForSeconds(1);
        RedLightOn.SetActive(true);
        BeepSound1.Play();
        Countone.SetActive(true);

        yield return new WaitForSeconds(1);
        RedLightOn.SetActive(false);
        OrangeLightOn.SetActive(true);
        BeepSound1.Play();
        Countone.SetActive(false);
        Counttwo.SetActive(true);

        yield return new WaitForSeconds(1);
        OrangeLightOn.SetActive(false);
        GreenLightOn.SetActive(true);
        BeepSound1.Play();
        Counttwo.SetActive(false);
        Countthree.SetActive(true);

        yield return new WaitForSeconds(1f);
        GreenLightOn.SetActive(false);
        BeepSound2.Play();
        Countthree.SetActive(false);
        RedLightOff.SetActive(false);
        GreenLightOff.SetActive(false);
        OrangeLightOff.SetActive(false);
        lightsBackground.SetActive(false);
        GO.SetActive(true);


        yield return new WaitForSeconds(.5f);
        SaveScript.RaceStart = true;
        GO.SetActive(false);
        

    }
    void Update()
    {
        
    }
}
