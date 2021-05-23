using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Analyzing", menuName = "FSM/Decision/Analyzing")]

public class Analyzing : FSMdecision
{
	public override bool Decide(FSMcontroller controller)
	{
		return VoiceRecognizer.instance.startedAnalysis;
	}
}
