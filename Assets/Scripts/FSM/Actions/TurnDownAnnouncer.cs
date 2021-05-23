using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TurnDownAnnouncer", menuName = "FSM/Action/Turn Down Announcer")]
public class TurnDownAnnouncer : FSMaction
{
    public float newVolume;
    public override void Act(FSMcontroller controller)
    {
        var aS = AudioPlayer.instance.GetComponents<AudioSource>();
        aS[1].volume = newVolume;
    }
}
