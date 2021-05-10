using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WordOR", menuName = "FSM/Decision/Word OR")]
public class WordOR : FSMdecision
{
	public string[] words;
	public override bool Decide(FSMcontroller controller)
	{
		if (SentenceAnalyzer.instance.sentence != null)
		{
			string sentence = SentenceAnalyzer.instance.sentence;
			foreach (string word in words)
			{
				if (sentence.Contains(word)) return true;
			}

		}
		return false;
	}
}
