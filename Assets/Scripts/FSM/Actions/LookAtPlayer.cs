using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New LookAtPlayer", menuName = "FSM/Action/Look At Player")]
public class LookAtPlayer : FSMaction
{
	public override void Act(FSMcontroller controller)
	{
		Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

		// There could be a problem if the player isn't exactly in Y = 0.
		playerPosition.y = 0.0f;
		controller.transform.LookAt(playerPosition);
	}
}
