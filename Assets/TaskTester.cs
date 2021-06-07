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
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TaskHandler.instance.flags[1] = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TaskHandler.instance.flags[2] = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            TaskHandler.instance.flags[3] = true;

        }
    }
}
