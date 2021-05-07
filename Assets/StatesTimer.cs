using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesTimer : MonoBehaviour
{
    public float timer;
    public bool active;
    public bool timerFinished;

    void Start()
    {
        active = false;
        timerFinished = false;
    }

    void Update()
    {
        if (active)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                active = false;
                timerFinished = true;
            }
        }
    }
    public void SetTimer(float time) {
        timer = time;
        timerFinished = false;
        active = true;
    }

    public void StopTimer()
    {
        active = false;
        timerFinished = false;
    }
    
}
