using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Voice", menuName = "FSM/Action/Voice")]

public class Voice : FSMaction
{
    public bool useKeywords;
    public override void Act(FSMcontroller controller)
    { 
        if (useKeywords)
        {
            VoiceInteraction.instance.On();
            VoiceRecognizer.instance.Off();

        }

        else
        {
            VoiceRecognizer.instance.On();
            VoiceInteraction.instance.Off();
        }
    }
}
