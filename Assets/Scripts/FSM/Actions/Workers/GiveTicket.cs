using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GiveTicket", menuName = "FSM/Action/Give Ticket")]

public class GiveTicket : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        controller.GetComponent<TicketSeller>().GiveTicket();
    }
}