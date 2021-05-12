using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AvatarSays", menuName = "FSM/Action/Avatar Says")]

public class AvatarSays : FSMaction
{
    public AudioClip audioF, audioM;
    public override void Act(FSMcontroller controller)
    {
        if (VoiceRecognizer.instance.startedAnalysis)
        {
            if (condition.Decide(controller))
            {
                controller.GetComponent<Interaction>().Say(audioF, audioM);
                VoiceRecognizer.instance.startedAnalysis = false;
            }
        }
    }
}

