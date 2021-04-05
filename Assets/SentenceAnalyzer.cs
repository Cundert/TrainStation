using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceAnalyzer : MonoBehaviour
{
	public static SentenceAnalyzer instance;

	public string[] greetings;
	public string[] asking;
	public string[] objectsAsked;

	private bool userGreeting;
	public string sentence;
	bool forgetting;
	public bool goBackToListening;

	void Start()
	{
		if (SentenceAnalyzer.instance) Destroy(this);
		SentenceAnalyzer.instance = this;
	}
	IEnumerator forgetSentence()
    {
		yield return new WaitForSeconds(1.5f);
		if (forgetting) sentence = null;
		forgetting = false;
		yield return null;
    }
	public void Analyze(string textReceived)
    {
		StopAllCoroutines();
		sentence = textReceived;
		forgetting = true;
		print("text received");
		if (CheckPlayerGreeting(sentence)) Greeting(); 
		StartCoroutine(forgetSentence());
    }
	private void Greeting()
	{
		VoiceRecognizer.instance.startedAnalysis = false;
		userGreeting = true;
	}
	public void NotGreeting()
	{
		userGreeting = false;
	}

	public bool isGreetingSomeone()
	{
		return userGreeting;
	}

	private bool CheckPlayerGreeting(string text)
	{
		foreach (string word in greetings)
		{
			if (text.Contains(word)) return true;
		}
		return false;
	}

	private bool CheckPlayerAsking(string text)
	{
		foreach (string word in asking)
		{
			if (text.Contains(word)) return true;
		}
		return false;
	}

	private int CheckPlayerLookingForObject(string text)
	{
		foreach (string sentence in asking)
		{
			string[] objects = sentence.Split(' ');
			int counter = 0;
			foreach (string word in objects)
			{
				if (text.Contains(word))
				{
					return counter;
				}
				counter++;
			}
		}
		return -1;
	}
}
