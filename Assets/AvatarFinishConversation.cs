using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AvatarFinishConversation : MonoBehaviour
{
    public static AvatarFinishConversation instance;
    StreamWriter writer;
    string path;

    // Start is called before the first frame update
    void Start()
    {
        if (AvatarFinishConversation.instance) Destroy(this);
        AvatarFinishConversation.instance = this;

        path = ManageCollectors.instance.pathForCurrentIteration() + "/AvatarFinishConversation.csv";
        writer = new StreamWriter(path, true);
        writer.WriteLine("Ending conversation time");
        writer.Close();
    }

    public void WriteFinishData()
    {
        writer = new StreamWriter(path, true);
        writer.WriteLine(Time.time.ToString().Replace(',', '.'));
        writer.Close();
    }
}
