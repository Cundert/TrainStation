using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WordOR", menuName = "FSM/Decision/Word OR")]
public class WordOR : FSMdecision
{
	public string[] words;
	public override bool Decide(FSMcontroller controller)
	{
		foreach (string word in words)
        {
			if (SentenceAnalyzer.instance.sentence.Contains(word)) return true;
        }
		return false;
	}
}
