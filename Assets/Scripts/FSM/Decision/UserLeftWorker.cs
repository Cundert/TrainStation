using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new UserLeftWorker", menuName = "FSM/Decision/User Left Worker")]
public class UserLeftWorker : FSMdecision
{
	private Vector3 pointA;
	private Vector3 pointB;
	public override bool Decide(FSMcontroller controller)
	{

		pointA = new Vector3(controller.transform.position.x + 2.5f, 0, controller.transform.position.z + 1.2f);
		pointB = new Vector3(controller.transform.position.x + 0.9f, 0, controller.transform.position.z - 1.2f);

		Vector3 pl = PlayerPosition.instance.position;
		if ((pl.x >= pointA.x && pl.x <= pointB.x) || (pl.x >= pointB.x && pl.x <= pointA.x))
		{
			if ((pl.z >= pointA.z && pl.z <= pointB.z) || (pl.z >= pointB.z && pl.z <= pointA.z))
			{
				return false;
			}
		}
		return true;
	}
}
