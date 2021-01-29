using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UserInteracting", menuName = "FSM/Decision/User Interacting")]

public class UserInteracting : FSMdecision
{
	public override bool Decide(FSMcontroller controller)
	{
		return Input.GetMouseButtonDown(0);
	}
}
