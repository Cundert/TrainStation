using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New KeyWordUpdate", menuName = "FSM/Action/KeyWord Update")]

public class KeyWordUpdate : FSMaction
{
	public WordOR[] arrayOfWordLists;
	public override void Act(FSMcontroller controller)
	{
		KeywordsBox.instance.updateCurrentKeywords(arrayOfWordLists);
	}
}
