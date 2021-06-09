using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTester : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TaskHandler.instance.flags[0] = true;
            TasksData.instance.UpdateTasks(0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TaskHandler.instance.flags[1] = true; 
            TasksData.instance.UpdateTasks(1);


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TaskHandler.instance.flags[2] = true; 
            TasksData.instance.UpdateTasks(2);


        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            TaskHandler.instance.flags[3] = true; 


        }
    }
}
