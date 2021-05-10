using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SayWithNoCondition", menuName = "FSM/Action/Say With No Condition")]

public class SayWithNoCondition : FSMaction
{
    public AudioClip audioF;
    public AudioClip audioM;

    public override void Act(FSMcontroller controller)
    {
        if (VoiceRecognizer.instance.startedAnalysis)
        {
                controller.GetComponent<Interaction>().Say(audioF, audioM);
                VoiceRecognizer.instance.startedAnalysis = false;
        }
    }
}
