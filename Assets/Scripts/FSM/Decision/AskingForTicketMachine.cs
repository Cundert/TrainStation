using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AskingForTicketMachine", menuName = "FSM/Decision/Asking For Ticket Machine")]

public class AskingForTicketMachine : FSMdecision
{
	public override bool Decide(FSMcontroller controller)
	{
		return Input.GetMouseButtonDown(1);
	}
}
