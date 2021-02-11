using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ListenAgain", menuName = "FSM/Decision/Listen Again")]

public class ListenAgain : FSMdecision
{
	// Start is called before the first frame update
	public override bool Decide(FSMcontroller controller)
	{
		return SentenceAnalyzer.instance.goBackToListening;
	}
}
