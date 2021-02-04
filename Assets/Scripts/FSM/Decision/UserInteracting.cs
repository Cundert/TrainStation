using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UserInteracting", menuName = "FSM/Decision/User Interacting")]

public class UserInteracting : FSMdecision
{

	public override bool Decide(FSMcontroller controller)
	{
		bool beingLooked = ObservedAvatar.instance.getAvatar() == controller.transform.gameObject;
		bool userGreeting = VoiceInteraction.instance.isGreetingSomeone();

		if (beingLooked && userGreeting) { 
			VoiceInteraction.instance.NotGreeting();
			Debug.Log("Ha saludado" + userGreeting + "\n Me esta mirando"  + beingLooked );
		}
		return beingLooked && (Input.GetMouseButtonDown(0) || userGreeting);
	}
}
