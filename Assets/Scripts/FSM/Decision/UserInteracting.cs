using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UserInteracting", menuName = "FSM/Decision/User Interacting")]

public class UserInteracting : FSMdecision
{

	public override bool Decide(FSMcontroller controller)
	{
        bool beingLooked = AvatarDetector.instance.currentlyObservedAvatar == controller.transform.gameObject;
        //bool userGreeting = SentenceAnalyzer.instance.isGreetingSomeone();

        bool greet = controller.GetComponent<Interaction>().greeted;
		if (greet) controller.GetComponent<Interaction>().greeted = false;
		//if (beingLooked && userGreeting) {
		//	AvatarDetector.instance.currentlyInteractingAvatar = controller.transform.gameObject;
		//	SentenceAnalyzer.instance.NotGreeting();
		//}
		return greet  || (beingLooked && Input.GetMouseButtonDown(0));

		//return beingLooked && (Input.GetMouseButtonDown(0) || userGreeting);
	}
}
