using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AvatarSays", menuName = "FSM/Action/Avatar Says")]
public class AvatarSays : FSMaction
{
    public string sentenceToBeSaid;
    public override void Act(FSMcontroller controller)
    {
        if (condition.Decide(controller))
        {
            // At the moment it only prints the sentence in console
            Debug.Log(sentenceToBeSaid);
        }
    }
}
