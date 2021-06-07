using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TicketValidated", menuName = "FSM/Action/Ticket Validated")]

public class TicketValidated : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        controller.GetComponent<TicketValidator>().TicketValidated();
    }
}