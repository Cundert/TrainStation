using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersInteraction : MonoBehaviour
{

    public static WorkersInteraction instance;
    public bool firstIterationCompleted;
    // Start is called before the first frame update
    void Start()
    {
        if (WorkersInteraction.instance) Destroy(this);
        WorkersInteraction.instance = this;
        firstIterationCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
