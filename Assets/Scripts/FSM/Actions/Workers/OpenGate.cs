using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New OpenGate", menuName = "FSM/Action/Open Gate")]

public class OpenGate : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        controller.GetComponent<Gate>().Open();
    }
}