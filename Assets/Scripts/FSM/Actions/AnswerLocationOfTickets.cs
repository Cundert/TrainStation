using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AnswerLocationOfTickets", menuName = "FSM/Action/Answer Location Of Tickets")]
public class AnswerLocationOfTickets : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        if (condition.Decide(controller))
        {
            float playerXPosition = PlayerPosition.instance.position.x;
            if (playerXPosition < -14) Debug.Log("Busca en los extremos de la entrada a la estacion");
            else if (playerXPosition < 4) Debug.Log("Mira a los extremos de esta sala");
            else Debug.Log("Entra y mira a los extremos de la entrada");
        }
    }
}
