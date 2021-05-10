using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New LookAtPlayer", menuName = "FSM/Action/Look At Player")]
public class LookAtPlayer : FSMaction
{
	public override void Act(FSMcontroller controller)
	{
		Vector3 lookAt = PlayerPosition.instance.position - controller.gameObject.transform.position;
		AvatarDetector.instance.currentlyInteractingAvatar = controller.transform.gameObject;
		// There could be a problem if the player isn't exactly in Y = 0.

		lookAt.y = 0.0f;
		var rotation = Quaternion.LookRotation(lookAt);
		controller.GetComponent<Interaction>().startLookingAt(rotation);
		//controller.transform.rotation = rotation;
	}
}
