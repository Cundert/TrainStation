using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TurnXKeyWordDisplay", menuName = "FSM/Action/Turn X KeyWord Display")]

public class TurnXKeyWordDisplay : FSMaction
{
	public bool negate;
	public override void Act(FSMcontroller controller)
	{
		KeywordsBox.instance.TurnXKeyWordDisplay(!negate);
	}
}
