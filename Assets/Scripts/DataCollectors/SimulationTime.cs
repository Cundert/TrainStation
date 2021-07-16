using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SimulationTime : MonoBehaviour
{
    StreamWriter writer;
    string path;

    // Start is called before the first frame update
    void Start()
    {
        path = ManageCollectors.instance.pathForCurrentIteration() + "/SimulationTime.csv";
    }

    private void OnApplicationQuit()
    {
        writer = new StreamWriter(path, true);
        writer.WriteLine("Simulation duration time");
        writer.WriteLine(Time.time.ToString().Replace(',', '.'));
        writer.Close();
    }
}
