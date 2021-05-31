using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersFSMManager : MonoBehaviour
{
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
        completedInteractions = 0;
        assignedFSM = new bool[6];
    }
    void Update()
    {
        
    }
    void updateFSMs()
    {
        completedInteractions++;
        // modificar el array de booleanos como convenga a partir de un parametro de esta misma funcion
        switch (completedInteractions) {
            case 1:
                AssignStateToUnusedWorkers(First1);
            break;
            case 2:
                AssignStateToUnusedWorkers(Second1);
                break;
            case 3:
                AssignStateToUnusedWorkers(Zero1);
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
