using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New NextStateFlag", menuName = "FSM/Decision/Next State Flag")]

public class NextStateFlag : FSMdecision
{
	// Start is called before the first frame update
	public override bool Decide(FSMcontroller controller)
	{
		return StatesTimer.instance.active;
	}
}

