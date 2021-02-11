using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UserInteracting", menuName = "FSM/Decision/User Interacting")]

public class UserInteracting : FSMdecision
{

	public override bool Decide(FSMcontroller controller)
	{
		bool beingLooked = AvatarDetector.instance.currentlyObservedAvatar == controller.transform.gameObject;
		bool userGreeting = SentenceAnalyzer.instance.isGreetingSomeone();

		if (beingLooked && userGreeting) {
			AvatarDetector.instance.currentlyInteractingAvatar = controller.transform.gameObject;
			SentenceAnalyzer.instance.NotGreeting();
		}
		return beingLooked && (Input.GetMouseButtonDown(0) || userGreeting);
	}
}
