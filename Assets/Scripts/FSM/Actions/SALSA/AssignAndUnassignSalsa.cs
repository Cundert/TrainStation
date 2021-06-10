using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AssignAndUnassignSalsa", menuName = "FSM/Action/Assign And Unassign Salsa")]
public class AssignAndUnassignSalsa : FSMaction {
    public bool assign;
	public override void Act(FSMcontroller controller) {
        if(assign) 
		controller.gameObject.AddComponent<CrazyMinnow.SALSA.Fuse.CM_FuseSetup>();

        else
        {
            var comps = controller.gameObject.GetComponents<CrazyMinnow.SALSA.RandomEyes3D>();

            foreach (var comp in comps)
            {
                Destroy(comp);
            }

            Destroy(controller.gameObject.GetComponent<CrazyMinnow.SALSA.Salsa3D>());
            Destroy(controller.gameObject.GetComponent<CrazyMinnow.SALSA.Fuse.CM_FuseSync>());
        }
    }

}
