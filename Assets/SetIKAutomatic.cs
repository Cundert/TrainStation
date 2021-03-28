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

    GameObject Lindex0;
    GameObject Lindex1;
    GameObject Lindex2;

    GameObject Lmid0;
    GameObject Lmid1;
    GameObject Lmid2;

    GameObject Lthumb0;
    GameObject Lthumb1;
    GameObject Lthumb2;

    GameObject Lring0;
    GameObject Lring1;
    GameObject Lring2;

    GameObject Llittle0;
    GameObject Llittle1;
    GameObject Llittle2;
    static int count = 0;

    void Awake()
    {

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

        // Fingers

        Lthumb0 = LWrist.transform.GetChild(0).gameObject;
        Lthumb1 = Lthumb0.transform.GetChild(0).gameObject;
        Lthumb2 = Lthumb1.transform.GetChild(0).gameObject;

        Lindex0 = LWrist.transform.GetChild(1).gameObject;
        Lindex1 = Lindex0.transform.GetChild(0).gameObject;
        Lindex2 = Lindex1.transform.GetChild(0).gameObject;

        Lmid0 = LWrist.transform.GetChild(2).gameObject;
        Lmid1 = Lmid0.transform.GetChild(0).gameObject;
        Lmid2 = Lmid1.transform.GetChild(0).gameObject;

        Lring0 = LWrist.transform.GetChild(3).gameObject;
        Lring1 = Lring0.transform.GetChild(0).gameObject;
        Lring2 = Lring1.transform.GetChild(0).gameObject;

        Llittle0 = LWrist.transform.GetChild(4).gameObject;
        Llittle1 = Llittle0.transform.GetChild(0).gameObject;
        Llittle2 = Llittle1.transform.GetChild(0).gameObject;

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

        //Fingers

        fbik.leftHandFingersBones.thumb[0].transform = Lthumb0.transform;
        fbik.leftHandFingersBones.thumb[1].transform = Lthumb1.transform;
        fbik.leftHandFingersBones.thumb[2].transform = Lthumb2.transform;
        fbik.leftHandFingersEffectors.thumb.positionEnabled = true;

        fbik.leftHandFingersBones.index[0].transform = Lindex0.transform;
        fbik.leftHandFingersBones.index[1].transform = Lindex1.transform;
        fbik.leftHandFingersBones.index[2].transform = Lindex2.transform;
        fbik.leftHandFingersEffectors.index.positionEnabled = true;

        fbik.leftHandFingersBones.middle[0].transform = Lmid0.transform;
        fbik.leftHandFingersBones.middle[1].transform = Lmid1.transform;
        fbik.leftHandFingersBones.middle[2].transform = Lmid2.transform;
        fbik.leftHandFingersEffectors.middle.positionEnabled = true;

        fbik.leftHandFingersBones.ring[0].transform = Lring0.transform;
        fbik.leftHandFingersBones.ring[1].transform = Lring1.transform;
        fbik.leftHandFingersBones.ring[2].transform = Lring2.transform;
        fbik.leftHandFingersEffectors.ring.positionEnabled = true;

        fbik.leftHandFingersBones.little[0].transform = Llittle0.transform;
        fbik.leftHandFingersBones.little[1].transform = Llittle1.transform;
        fbik.leftHandFingersBones.little[2].transform = Llittle2.transform;
        fbik.leftHandFingersEffectors.little.positionEnabled = true;

        fbik.headEffectors.neck.positionEnabled = true;
        fbik.headEffectors.neck.pull = .9f;
        fb.enabled = false;

    }
}