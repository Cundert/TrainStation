using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WorkerSays", menuName = "FSM/Action/Worker Says")]

public class WorkerSays : FSMaction
{
    public int sentence;
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        controller.GetComponent<Interaction>().WorkerSays(sentence);
    }
}