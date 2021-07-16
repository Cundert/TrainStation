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
	public bool goBackToListening;
	float timer = 1.5f;

	void Start()
	{
		if (SentenceAnalyzer.instance) Destroy(this);
		SentenceAnalyzer.instance = this;
	}

    private void Update()
    {
		if (timer > 0)
		{
			timer -= Time.deltaTime;
			if (timer < 0)
			{
				sentence = null;
			}
		}
	}
    public void Analyze(string textReceived)
    {
		sentence = textReceived;
		
		if (ConversationText.instance) // ConvText might not be active
			ConversationText.instance.StoreSentence(true, textReceived); 

		if (CheckPlayerGreeting(sentence)) Greeting(); 

    }
	private void Greeting()
	{
		//VoiceRecognizer.instance.startedAnalysis = false;
		//userGreeting = true;
		AvatarDetector.instance.GreetAvatar();
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
