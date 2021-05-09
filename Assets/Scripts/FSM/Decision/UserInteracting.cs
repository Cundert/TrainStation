using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UserInteracting", menuName = "FSM/Decision/User Interacting")]

public class UserInteracting : FSMdecision
{

	public override bool Decide(FSMcontroller controller)
	{
        bool beingLooked = AvatarDetector.instance.currentlyObservedAvatar == controller.transform.gameObject;

        bool greet = controller.GetComponent<Interaction>().greeted;

		// if the avatar is actually being greeted, it doesn't need to be greeted any longer
		if (greet) controller.GetComponent<Interaction>().greeted = false;

		return greet  || (beingLooked && Input.GetMouseButtonDown(0));

		//return beingLooked && (Input.GetMouseButtonDown(0) || userGreeting);
	}
}
