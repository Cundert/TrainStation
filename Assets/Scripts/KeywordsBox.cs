using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class KeywordsBox : MonoBehaviour
{
    public static KeywordsBox instance;
    private TMP_Text t;
    WordOR[] arrayWithKeywords;
    List <string> wordsToBeDisplayed;


    // Start is called before the first frame update
    void Awake()
    {
        if (KeywordsBox.instance) Destroy(this);
        KeywordsBox.instance = this;
        t = GetComponentInChildren<TMP_Text>();
        wordsToBeDisplayed = new List<string>();
        TurnXKeyWordDisplay(false);
    }

    public void updateCurrentKeywords(WordOR[] array)
    {
        wordsToBeDisplayed.Clear();

        foreach (WordOR dec in array)
        {
            //foreach (string word in dec.words) {
                wordsToBeDisplayed.Add(dec.words[0]);
            //}
        }

        string text = "";
        foreach(string word in wordsToBeDisplayed)
        {
            text += word + "\n";
        }
        t.text = text;
    }
    // Update is called once per frame
    void Update()
    {
        

    }
    public void TurnXKeyWordDisplay(bool OnOff)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(OnOff);
        }
    }
}
