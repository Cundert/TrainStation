using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersReset : MonoBehaviour
{
    private Animator anim;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 1;
        anim = GetComponent<Animator>();
    }
    private void ResetAllTriggers()
    {
        foreach (var param in anim.parameters)
        {
            if (param.type == AnimatorControllerParameterType.Trigger)
            {
                anim.ResetTrigger(param.name);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ResetAllTriggers();
            timer = 2;
        }
    }
}
