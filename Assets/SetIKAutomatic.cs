using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIKAutomatic : MonoBehaviour
{
    SA.FullBodyIKBehaviour fb;
    SA.FullBodyIK fbik;
    GameObject pelvis;
    GameObject spine;
    GameObject neck;

    GameObject LLeg;
    GameObject LKnee;
    GameObject LFoot;

    GameObject RLeg;
    GameObject RKnee;
    GameObject RFoot;

    GameObject LArm;
    GameObject LElbow;
    GameObject LWrist;

    GameObject RArm;
    GameObject RElbow;
    GameObject RWrist;


    void Awake()
    {
        //Debug.Log(InvertedKinematics.instance.activate);
        //if (InvertedKinematics.instance.activate)
        //{

            fb = GetComponent<SA.FullBodyIKBehaviour>();
            fbik = fb.fullBodyIK;

            pelvis = transform.GetChild(0).GetChild(1).gameObject;
            spine = pelvis.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            neck = spine.transform.GetChild(0).gameObject;

            LLeg = pelvis.transform.GetChild(0).GetChild(0).gameObject;
            LKnee = LLeg.transform.GetChild(0).gameObject;
            LFoot = LKnee.transform.GetChild(0).gameObject;

            RLeg = pelvis.transform.GetChild(0).GetChild(1).gameObject;
            RKnee = RLeg.transform.GetChild(0).gameObject;
            RFoot = RKnee.transform.GetChild(0).gameObject;


            LArm = spine.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            LElbow = LArm.transform.GetChild(0).gameObject;
            LWrist = LElbow.transform.GetChild(0).gameObject;

            RArm = spine.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            RElbow = RArm.transform.GetChild(0).gameObject;
            RWrist = RElbow.transform.GetChild(0).gameObject;

            ////////////////////////////////////////////////////////////////////////

            fbik.bodyBones.hips.transform = pelvis.transform;
            fbik.bodyBones.spine.transform = spine.transform;

            fbik.headBones.neck.transform = neck.transform;

            fbik.leftLegBones.leg.transform = LLeg.transform;
            fbik.leftLegBones.knee.transform = LKnee.transform;
            fbik.leftLegBones.foot.transform = LFoot.transform;

            fbik.rightLegBones.leg.transform = RLeg.transform;
            fbik.rightLegBones.knee.transform = RKnee.transform;
            fbik.rightLegBones.foot.transform = RFoot.transform;

            fbik.leftArmBones.arm.transform = LArm.transform;
            fbik.leftArmBones.elbow.transform = LElbow.transform;
            fbik.leftArmBones.wrist.transform = LWrist.transform;

            fbik.rightArmBones.arm.transform = RArm.transform;
            fbik.rightArmBones.elbow.transform = RElbow.transform;
            fbik.rightArmBones.wrist.transform = RWrist.transform;

            fb.enabled = false;

        //}
    }
}