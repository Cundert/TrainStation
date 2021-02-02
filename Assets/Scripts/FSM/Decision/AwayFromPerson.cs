using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AwayFromPerson", menuName = "FSM/Decision/Away From Person")]

public class AwayFromPerson : FSMdecision
{
	public float distance;
	public override bool Decide(FSMcontroller controller)
	{
		return Vector3.Distance(PlayerPosition.instance.position, controller.transform.position) > distance;
	}
}
