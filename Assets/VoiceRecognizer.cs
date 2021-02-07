using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecognizer : MonoBehaviour
{
    private DictationRecognizer dictationRecognizer;

	public static VoiceRecognizer instance;
	// Use this for initialization
	void Start()
	{
		if (VoiceRecognizer.instance) Destroy(this);
		VoiceRecognizer.instance = this;

		dictationRecognizer = new DictationRecognizer();

		//dictationRecognizer.AutoSilenceTimeoutSeconds = 5;

		dictationRecognizer.DictationResult += DictationRecognizer_DictationResult;
		dictationRecognizer.DictationComplete += DictationRecognizer_DictationComplete;
	}
	public void On()
    {
		dictationRecognizer.Start();
    }

	public void Off()
    {
		dictationRecognizer.Stop();
    }

	private void DictationRecognizer_DictationResult(string text, ConfidenceLevel confidence)   //aqui va todo lo que se maneje con resultado de voz... osea lo convertido a "texto"
	{
		dictationRecognizer.Start();
		print(text + " " + confidence);
	}


	private void DictationRecognizer_DictationComplete(DictationCompletionCause cause)  //aqui va cuando ya todo haya acabado.. osea cuando dejes de hablar y pase el tiempo de reconocimiento
	{
		dictationRecognizer.Stop();
		print("Recognizer stopped");
		//PhraseRecognitionSystem.Restart();  //y esto sirve para reactivar el phrase.. osea para que nuestro script "voz" funcione a la normalidad... 
	}

	
	void OnDestroy()
	{
		dictationRecognizer.DictationResult -= DictationRecognizer_DictationResult;
		dictationRecognizer.DictationComplete -= DictationRecognizer_DictationComplete;
		dictationRecognizer.Dispose();
	}
}
