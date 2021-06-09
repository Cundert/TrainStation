using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TasksData : MonoBehaviour
{

    public static TasksData instance;
    StreamWriter writer;
    string path;

    // Start is called before the first frame update
    void Start()
    {
        if (TasksData.instance) Destroy(this);
        TasksData.instance = this;

        path = ManageCollectors.instance.pathForCurrentIteration() + "/TaskData.csv";
        writer = new StreamWriter(path, true);
        writer.WriteLine("Task, Timestamp");
        writer.Close();
        print(path);
    }

    // Update is called once per frame
    public void UpdateTasks(int num)
    {
        writer = new StreamWriter(path, true);

        switch (num)
        {
            case 0:
                writer.WriteLine("Billete a Girona" + "," + Time.time.ToString().Replace(",", "."));
                break;
            case 1:
                writer.WriteLine("Billete a Paris" + "," + Time.time.ToString().Replace(",", "."));
                break;
            case 2:
                writer.WriteLine("Vaso de cafe" + "," + Time.time.ToString().Replace(",", "."));
                break;
            default:
                break;
        }
        writer.Close();
    }
}
