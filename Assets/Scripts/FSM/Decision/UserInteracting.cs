using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UserInteracting", menuName = "FSM/Decision/User Interacting")]

public class UserInteracting : FSMdecision
{
	public bool beingLooked;
	public override bool Decide(FSMcontroller controller)
	{
		beingLooked = ObservedAvatar.instance.getAvatar() == controller.transform.gameObject;
		return beingLooked && Input.GetMouseButtonDown(0);
	}
}
