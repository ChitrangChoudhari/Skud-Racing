using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   
    void Start()
    {
       
            this.GetComponent<Renderer>().material.color = SaveScript.SupportsCarColor;
      
      
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
