using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColor : MonoBehaviour
{
    public byte Red;
    public byte Green;
    public byte Blue;
    public byte Alpha;
    public static bool Change = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetColor()
    {
        SaveScript.PreviewCarColor = new Color32(Red, Green, Blue, Alpha);
        Change = true;
    }
}
