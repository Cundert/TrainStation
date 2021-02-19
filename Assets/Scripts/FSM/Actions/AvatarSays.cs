using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AvatarSays", menuName = "FSM/Action/Avatar Says")]
public class AvatarSays : FSMaction
{
    public int sentence;
    public override void Act(FSMcontroller controller)
    {
        if (condition.Decide(controller))
        {
            controller.GetComponent<Interaction>().AnswerQuestion(sentence);
            Debug.Log(sentence);
        }
    }
}
