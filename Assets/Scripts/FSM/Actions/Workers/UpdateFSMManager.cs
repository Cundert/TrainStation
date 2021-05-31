using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UpdateFSMManager", menuName = "FSM/Action/Update FSM Manager")]

public class UpdateFSMManager : FSMaction
{
    public int numberInteraction;
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        WorkersFSMManager.instance.updateFSMs(controller.transform.position.z, numberInteraction);
    }
}