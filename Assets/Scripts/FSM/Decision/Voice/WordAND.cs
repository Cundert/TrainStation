using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WordAND", menuName = "FSM/Decision/Word AND")]
public class WordAND : FSMdecision
{
	public string[] words;
	public override bool Decide(FSMcontroller controller)
	{
		foreach (string word in words)
		{
			if (!SentenceAnalyzer.instance.sentence.Contains(word)) return false;
		}
		return true;
	}
}
