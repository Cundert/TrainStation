using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AwayFromPerson", menuName = "FSM/Decision/Away From Person")]

public class AwayFromPerson : FSMdecision
{
	public float distance;
	public bool insideDistance;

	public override bool Decide(FSMcontroller controller)
	{
		if (AvatarDetector.instance.currentlyInteractingAvatar != null)
		{
			float calculatedDistance = Vector3.Distance(PlayerPosition.instance.position,
									AvatarDetector.instance.currentlyInteractingAvatar.transform.position);

			if (insideDistance) return calculatedDistance < distance;

			else return calculatedDistance >= distance;
		}
		else return false;
	}
}
