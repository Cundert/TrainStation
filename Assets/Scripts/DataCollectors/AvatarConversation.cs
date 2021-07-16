using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AvatarConversation : MonoBehaviour
{
    public static AvatarConversation instance;
    StreamWriter writer;
    string path;
    string gender;
    bool worker;
    string distance, iniTime, finishTime;
    // Start is called before the first frame update
    void Start()
    {
        if (AvatarConversation.instance) Destroy(this);
        AvatarConversation.instance = this;

        path = ManageCollectors.instance.pathForCurrentIteration() + "/AvatarConversation.csv";
        writer = new StreamWriter(path, true);
        writer.WriteLine("Gender,Is Worker,Talking distance,Starting conversation time, Finish conversation Time");
        writer.Close();
    }

    public void StoreIniData(string g, bool w, float d, float iniT)
    {
        gender = g;
        worker = w;
        distance = d.ToString().Replace(",", ".");
        iniTime = iniT.ToString().Replace(",", ".");
    }
    public void ConversationFinished()
    {
        writer = new StreamWriter(path, true);
        writer.WriteLine(gender + ',' + worker + ',' + distance + ',' + iniTime + ',' + Time.time.ToString().Replace(",", "."));
        writer.Close();
    }
}
