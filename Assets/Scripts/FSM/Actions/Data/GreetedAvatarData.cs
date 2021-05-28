using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GreetedAvatarData", menuName = "FSM/Action/Greeted Avatar Data")]
public class GreetedAvatarData : FSMaction
{
    public override void Act(FSMcontroller controller)
    {
        string female = controller.name.Contains("F") ? "Female":  "Male";
        bool worker = controller.transform.parent.name.Contains("W");

        Vector2 playerPos = new Vector2(PlayerPosition.instance.position.x, PlayerPosition.instance.position.z);
        Vector2 avatarPos = new Vector2(controller.transform.position.x, controller.transform.position.z);

        float distance = Vector2.Distance(playerPos, avatarPos);

        float iniTime = Time.time;

        AvatarConversation.instance.StoreIniData(female, worker, distance, iniTime);
    }
}
