using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AvatarSaysArray", menuName = "FSM/Action/Avatar Says Array")]

public class AvatarSaysArray : FSMaction
{
    public AudioClip[] audioF;
    public AudioClip[] audioM;
    public string text;

    public override void Act(FSMcontroller controller)
    {
        if (VoiceRecognizer.instance.startedAnalysis)
        {
            if (condition == null || condition.Decide(controller))
            {
                controller.GetComponent<Interaction>().Say(audioF, audioM);
                VoiceRecognizer.instance.startedAnalysis = false;
                ConversationText.instance.StoreSentence(false, text);
            }
        }
    }
}

