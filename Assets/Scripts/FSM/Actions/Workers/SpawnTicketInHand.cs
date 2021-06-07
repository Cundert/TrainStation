using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SpawnTicketInHand", menuName = "FSM/Action/Spawn Ticket In Hand")]

public class SpawnTicketInHand : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        controller.GetComponent<TicketValidator>().SpawnTicketInUserHand();
    }
}