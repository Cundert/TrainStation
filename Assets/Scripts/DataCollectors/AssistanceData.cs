using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AssistanceData : MonoBehaviour
{
    public static AssistanceData instance;
    StreamWriter writer;
    string path;
    public bool assistUser;

    // Start is called before the first frame update
    void Start()
    {
        if (AssistanceData.instance) Destroy(this);
        AssistanceData.instance = this;

        path = ManageCollectors.instance.pathForCurrentIteration() + "/AssistanceData.csv";
        writer = new StreamWriter(path, true);
        writer.WriteLine("IsUserAssisted");
        writer.WriteLine(assistUser);
        writer.Close();

        MessageVR.instance.transform.parent.gameObject.SetActive(assistUser);
        KeywordsBox.instance.transform.parent.gameObject.SetActive(assistUser);
    }
}
