using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersFSMManager : MonoBehaviour
{
    public static WorkersFSMManager instance;

    public GameObject[] workers;
    public bool[] assignedFSM;

    public FSMstate Zero1;
    public FSMstate First1;
    public FSMstate Second1;

    int completedInteractions;

    bool firstInteraction;
    bool secondInteraction;
    bool thirdInteraction;

    void Start()
    {
        if (WorkersFSMManager.instance) Destroy(this);
        WorkersFSMManager.instance = this;

        completedInteractions = 0;
        assignedFSM = new bool[6];
    }
    void Update()
    {
        
    }
    public void updateFSMs(float workerZCoord, int interactionNumber)
    {
        updateArrayOfBools(workerZCoord);        

        switch (interactionNumber)
        {
            case 0:
                firstInteraction = true;
                break;
            case 1:
                secondInteraction = true;
                break;
            case 2:
                thirdInteraction = true;
                break;
        }
        
        if (thirdInteraction)
        {
            AssignStateToUnusedWorkers(Zero1);

        }
        else if (secondInteraction)
        {
            AssignStateToUnusedWorkers(Second1);

        }
        else if (firstInteraction)
        {
            AssignStateToUnusedWorkers(First1);

        }        
    }

    private void updateArrayOfBools(float workerZCoord)
    {
        switch (workerZCoord)
        {
            case -4.649f:
                assignedFSM[0] = true;
                break;

            case -2.305f:
                assignedFSM[1] = true;
                break;

            case 0.2f:
                assignedFSM[2] = true;
                break;

            case 2.608f:
                assignedFSM[3] = true;
                break;

            case 5.06f:
                assignedFSM[4] = true;
                break;

            case 7.49f:
                assignedFSM[5] = true;
                break;
            default:
                break;
        }
    }

    void AssignStateToUnusedWorkers(FSMstate state)
    {
        for (int i = 0; i < assignedFSM.Length; ++i)
        {
            if (assignedFSM[i] == false)
            {
                workers[i].GetComponent<FSMcontroller>().activeState = state;
            }
        }
    }
}
