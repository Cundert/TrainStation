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
    public bool userGreeting;
    private bool userSaysGoodbye;


    void Start()
    {
        if (VoiceInteraction.instance) Destroy(this);
        VoiceInteraction.instance = this;

        // Calling someone
        actions.Add("hola", Greeting);
        actions.Add("que tal", Greeting);
        actions.Add("hey", Greeting);
        actions.Add("perdona", Greeting);

        //Farewell
        actions.Add("adios", SayingGoodbye);
        actions.Add("hasta luego", SayingGoodbye);


        kr = new KeywordRecognizer(actions.Keys.ToArray());
        kr.OnPhraseRecognized += RecognizedSpeech;
        kr.Start();
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

    private void SayingGoodbye()
    {
        userSaysGoodbye = true;
    }
    public void NotSayingGoobye()
    {
        userSaysGoodbye = false;
    }

    public bool isGreetingSomeone()
    {
        return userGreeting;
    }
}
