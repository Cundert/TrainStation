using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AskingForTicketMachine", menuName = "FSM/Decision/AskingFor Ticket Machine")]

public class AskingForTicketMachine : FSMdecision
{
	public override bool Decide(FSMcontroller controller)
	{
		return Input.GetMouseButtonDown(1);
	}
}
