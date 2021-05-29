using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesTimer : MonoBehaviour
{
    public static StatesTimer instance;

    public float timer;
    public bool active;
    public float activeTimer;

    void Start()
    {
        if (StatesTimer.instance) Destroy(this);
        StatesTimer.instance = this;

        timer = 0;
        active = false;
        activeTimer = 0;
    }

    void Update()
    {
        if (timer>=0)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                active = true;
                activeTimer= 1;
            }
        }

        if (activeTimer >= 0)
        {
            activeTimer -= Time.deltaTime;
            if (activeTimer <= 0)
            {
                active = false;
            }
        }
    }
    public void SetTimer(float time)
    {
        active = false;
        timer = time;
    }  
}
