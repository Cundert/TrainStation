using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

[CreateAssetMenu(fileName = "New Voice", menuName = "FSM/Action/Voice")]

public class Voice : FSMaction
{
    public bool useKeywords;
    public override void Act(FSMcontroller controller)
    {
        if (useKeywords)
        {
            // To restart the Keyword system
            PhraseRecognitionSystem.Restart();
            VoiceRecognizer.instance.Off();
            VoiceInteraction.instance.On();
            AvatarDetector.instance.currentlyInteractingAvatar = null;
        }

        else
        {
            // To shutdown the Keyword system

            PhraseRecognitionSystem.Shutdown();
            VoiceInteraction.instance.Off();
            VoiceRecognizer.instance.On();
        }
    }
}
