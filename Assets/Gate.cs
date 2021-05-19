using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject leftDoor, rightDoor, center, arrow, newArrowPos;

    // Update is called once per frame

    public void Open()
    {
         StartCoroutine("OpenDoor");
    }

   IEnumerator OpenDoor()
    {
        center.transform.Rotate(new Vector3(0, 0, 180));

        if (PlayerPosition.instance.position.z > transform.position.z) //Open right door
        {
            arrow.transform.Rotate(new Vector3(0, 0, 180));
            arrow.transform.position = newArrowPos.transform.position;

            rightDoor.GetComponent<BoxCollider>().enabled = false;

            float iniDoorPos = rightDoor.transform.position.z;
            while (rightDoor.transform.position.z > iniDoorPos - 0.4) 
            {
                rightDoor.transform.Translate(new Vector3(0, -0.5f *Time.deltaTime, 0));
                yield return new WaitForEndOfFrame();

            }
        }
        else // Open left door
        {
            leftDoor.GetComponent<BoxCollider>().enabled = false;
            float iniDoorPos = leftDoor.transform.position.z;
            while (leftDoor.transform.position.z < iniDoorPos + 0.4) 
            {
                leftDoor.transform.Translate(new Vector3(0, 0.5f * Time.deltaTime, 0));
                yield return new WaitForEndOfFrame();
            }

        }
        yield return null;
    }
}
