using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAnswers : MonoBehaviour
{
    public static VoiceAnswers instance;

    public AudioClip[] female;
    public AudioClip[] male;

    public AudioClip[] wFemale;
    public AudioClip[] wMale;

    public AudioClip notUnderstoodFemale;
    public AudioClip notUnderstoodMale;

    // Start is called before the first frame update
    void Start()
    {
        if (VoiceAnswers.instance) Destroy(this);
        VoiceAnswers.instance = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
