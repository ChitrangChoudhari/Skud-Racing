using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewColor : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(ButtonColor.Change == true)
        {
            ButtonColor.Change = false;

            this.GetComponent<Renderer>().material.color = SaveScript.PreviewCarColor;

           
        }
    }
}
