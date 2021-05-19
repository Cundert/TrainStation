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
    string path = "Assets/Data/";

    Vector2 lastPosition;
    Vector2 currentPosition;
    float accumulatedDistance;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = Vector2.zero;
        currentPosition = Vector2.zero;
        accumulatedDistance = 0;

        int folderForCurrentIteration = ManageCollectors.instance.numberForCurrentIteration;
        path += folderForCurrentIteration.ToString() + "/PlayerTrajectory.txt";
        timer = 0.5f;
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

            currentPosition.x = float.Parse(x);
            currentPosition.y = float.Parse(z);

            accumulatedDistance += Vector2.Distance(lastPosition, currentPosition);
            lastPosition = currentPosition;

            writer = new StreamWriter(path, true);
            writer.Write(x + "\t" + z + "\t" + accumulatedDistance.ToString() + "\n");
            writer.Close();
        }
    }
}
