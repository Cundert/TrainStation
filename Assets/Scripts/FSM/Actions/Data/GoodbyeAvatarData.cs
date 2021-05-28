using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GoodbyeAvatarData", menuName = "FSM/Action/Goodbye Avatar Data")]
public class GoodbyeAvatarData : FSMaction
{
    public override void Act(FSMcontroller controller)
    {
        AvatarConversation.instance.ConversationFinished();
    }
}
