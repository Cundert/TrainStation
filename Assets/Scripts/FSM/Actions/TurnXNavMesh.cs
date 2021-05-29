using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TurnXNavMesh", menuName = "FSM/Action/Turn X NavMesh")]
public class TurnXNavMesh : FSMaction
{
    public bool negate;
    public override void Act(FSMcontroller controller)
    {
        if (negate) controller.GetComponent<NavMeshNavigator>().enabled = false;
        else controller.GetComponent<NavMeshNavigator>().enabled = true;
    }
}

