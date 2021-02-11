using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ActivateGoBackToListening", menuName = "FSM/Action/Activate GoBackToListening")]
public class ActivateGoBackToListening : FSMaction
{
    // Start is called before the first frame update
    public bool negate;
    public override void Act(FSMcontroller controller)
    {
        SentenceAnalyzer.instance.goBackToListening = !negate;
    }
}
