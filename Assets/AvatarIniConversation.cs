using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AvatarIniConversation : MonoBehaviour
{
    public static AvatarIniConversation instance;
    StreamWriter writer;
    string path;

    // Start is called before the first frame update
    void Start()
    {
        if (AvatarIniConversation.instance) Destroy(this);
        AvatarIniConversation.instance = this;

        path = ManageCollectors.instance.pathForCurrentIteration() + "/AvatarIniConversation.csv";
        writer = new StreamWriter(path, true);
        writer.WriteLine("Gender,Is Worker,Talking distance,Starting conversation time");
        writer.Close();
    }

    public void WriteIniData(string gender, bool worker, float distance, float iniTime)
    {
        writer = new StreamWriter(path, true);
        writer.WriteLine(gender + ',' + worker.ToString() + ',' + distance.ToString().Replace(',', '.') + ',' + iniTime.ToString().Replace(',', '.'));
        writer.Close();
    }
}
