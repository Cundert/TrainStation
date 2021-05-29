using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New StartTimerToNextState", menuName = "FSM/Action/Start Timer To Next State")]
public class StartTimerToNextState : FSMaction
{
    // Start is called before the first frame update
    public float time;
    public override void Act(FSMcontroller controller)
    {
        StatesTimer.instance.SetTimer(time);
    }
}