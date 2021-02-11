using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AnalysisStarted", menuName = "FSM/Decision/Analysis Started")]

public class AnalysisStarted : FSMdecision
{
	public override bool Decide(FSMcontroller controller)
	{
		return VoiceRecognizer.instance.startedAnalysis;
	}
}
