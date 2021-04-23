using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New FirstIterationCompleted", menuName = "FSM/Decision/First Iteration Completed")]
public class FirstIterationCompleted : FSMdecision
{
	public override bool Decide(FSMcontroller controller)
	{
		return WorkersInteraction.instance.firstIterationCompleted;
	}
}
