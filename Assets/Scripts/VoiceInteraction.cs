using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceInteraction : MonoBehaviour
{
    public static VoiceInteraction instance;

    private KeywordRecognizer kr;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    private bool userGreeting;

    public bool goBackToListening;

    void Start()
    {
        if (VoiceInteraction.instance) Destroy(this);
        VoiceInteraction.instance = this;

        // Greeting someone
        actions.Add("hola", Greeting);
        actions.Add("que tal", Greeting);
        actions.Add("hey", Greeting);
        actions.Add("perdona", Greeting);


        kr = new KeywordRecognizer(actions.Keys.ToArray());
        kr.OnPhraseRecognized += RecognizedSpeech;
        kr.Start();
    }

    public void On()
    {
        kr.Start();
    }

    public void Off()
    {
        kr.Stop();
    }

    // Function called if a phrase has been recognized
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text + " Key123");
        actions[speech.text].Invoke();
    }
    
    private void Greeting()
    {
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
}
