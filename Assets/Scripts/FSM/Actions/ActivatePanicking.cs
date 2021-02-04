using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ActivatePanicking", menuName = "FSM/Action/Activate Panicking")]
public class ActivatePanicking : FSMaction {

	public override void Act(FSMcontroller controller) {
		controller.GetComponent<NavMeshNavigator>().ActivatePanicking();
	}

}
