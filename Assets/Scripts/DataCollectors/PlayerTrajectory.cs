using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerTrajectory : MonoBehaviour
{
    public PlayerPosition playerPos;
    Vector3 [] positions ;
    float timer;
    
    StreamWriter writer;
    string path;

    Vector2 lastPosition;
    Vector2 currentPosition;
    float accumulatedDistance;

    // Start is called before the first frame update
    void Start()
    {
        path =  ManageCollectors.instance.pathForCurrentIteration() + "/PlayerTrajectory.csv";

        timer = 0.5f;
        writer = new StreamWriter(path, true);
        writer.WriteLine("x,z");
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        playerPos = PlayerPosition.instance;

        if (timer <= 0)
        {
            timer = 0.5f;
            string x = playerPos.position.x.ToString();
            string z = playerPos.position.z.ToString();

            x = x.Replace(",", ".");
            z = z.Replace(",", ".");

            currentPosition.x = float.Parse(x);
            currentPosition.y = float.Parse(z);

            
            writer.WriteLine(x + "," + z);
        }
    }

    private void OnApplicationQuit()
    {
        writer.Close();
    }
}
