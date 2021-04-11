using System;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecognizer : MonoBehaviour
{
    private DictationRecognizer dictationRecognizer;

	public static VoiceRecognizer instance;
	public bool startedAnalysis;

	// Use this for initialization
	void Start()
	{
		if (VoiceRecognizer.instance) Destroy(this);
		VoiceRecognizer.instance = this;

		dictationRecognizer = new DictationRecognizer();

        //dictationRecognizer.AutoSilenceTimeoutSeconds = 5;
        dictationRecognizer.DictationResult += DictationRecognizer_DictationResult;
		dictationRecognizer.DictationComplete += DictationRecognizer_DictationComplete;
		
		On();
	}
	public void On()
    {
		print("Recognizer on");
		dictationRecognizer.Start();
    }

	public void Off()
    {
		dictationRecognizer.Stop();
    }

	private void DictationRecognizer_DictationResult(string text, ConfidenceLevel confidence)
	{
		dictationRecognizer.Start();

		//if (confidence.Equals("High"))
		//{
			startedAnalysis = true;
			SentenceAnalyzer.instance.Analyze(text);
		//}
		print(text + " " + confidence);
	}

    
	private void DictationRecognizer_DictationComplete(DictationCompletionCause cause)
	{
		dictationRecognizer.Stop();
		print("Recognizer stopped");
		dictationRecognizer.Start();
	}


	void OnDestroy()
	{
		dictationRecognizer.DictationResult -= DictationRecognizer_DictationResult;
		dictationRecognizer.DictationComplete -= DictationRecognizer_DictationComplete;
		dictationRecognizer.Dispose();
	}
}
