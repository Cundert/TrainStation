using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New AnalysisFinished", menuName = "FSM/Action/Analysis Finished")]

public class AnalysisFinished : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        if(VoiceRecognizer.instance!=null)
        VoiceRecognizer.instance.startedAnalysis = false;
    }
}
