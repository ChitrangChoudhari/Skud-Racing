using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPositions : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;

    public GameObject Stats;

    public int AICarNumber;
    public bool Player;
    private int Pos;

    void Start()
    {
        if(AICarNumber == 1)
        {
            Pos = FinishLineAI.AICarBlackFinishPosition;
        }
        if (AICarNumber == 2)
        {
            Pos = FinishLineAI.AICarBlueFinishPosition;
        }
        if (AICarNumber == 3)
        {
            Pos = FinishLineAI.AICarRedFinishPosition;
        }
        if (AICarNumber == 4)
        {
            Pos = FinishLineAI.AICarYellowFinishPosition;
        }
        if(Player == true)
        {
            Pos = FinishLine.PlayerFinishPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Pos == 0)
        {
            Stats.SetActive(false);
        }
        if(Pos == 1)
        {
            Stats.transform.position = Slot1.transform.position;
        }
        if (Pos == 2)
        {
            Stats.transform.position = Slot2.transform.position;
        }
        if (Pos == 3)
        {
            Stats.transform.position = Slot3.transform.position;
        }
        if (Pos == 4)
        {
            Stats.transform.position = Slot4.transform.position;
        }
        if (Pos == 5)
        {
            Stats.transform.position = Slot5.transform.position;
        }
    }
}
