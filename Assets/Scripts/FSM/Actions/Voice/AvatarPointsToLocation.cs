using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New AvatarPointsToLocation", menuName = "FSM/Action/Avatar Points To Location")]

public class AvatarPointsToLocation : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        int location = controller.GetComponent<Interaction>().lastLocation;
        // There could be a problem if the player isn't exactly in Y = 0.

        Vector3 lookAt = Vector3.zero;

        float y = controller.gameObject.transform.position.y;

        switch (location)
        {
            //Ticket machines
            case 0:
                lookAt = new Vector3(-12.61f, y, 25.64f) - controller.gameObject.transform.position;
                break;
            //Drinks
            case 1:
                lookAt = new Vector3(-39.46f, y, -6.24f) - controller.gameObject.transform.position;
                break;

            //Platform
            case 2:
                lookAt = new Vector3(-73.16f, y, 0f) - controller.gameObject.transform.position;
                break;

            //Mobile charger
            case 3:
                lookAt = new Vector3(-57.68f, y, 18.4f) - controller.gameObject.transform.position;

                break;

            //Duty free
            case 4:
                lookAt = new Vector3(-35.01f, y, -19.8f) - controller.gameObject.transform.position;

                break;
            default:
                break;

        }

        var rotation = Quaternion.LookRotation(lookAt);
        controller.transform.rotation = rotation;
        controller.gameObject.GetComponent<AvatarPointing>().Point();
    }
}
