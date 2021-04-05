using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPointing : MonoBehaviour
{
    Vector3 reference;
    public float x, y, z;
    public float xr, yr, zr;

    GameObject LHand;
    GameObject RHand;

    GameObject RFoot;

    GameObject LThumb;
    GameObject LIndex;
    GameObject LMiddle;
    GameObject LRing;
    GameObject LLittle;

    GameObject RThumb;
    GameObject RIndex;
    GameObject RMiddle;
    GameObject RRing;
    GameObject RLittle;

    Vector3 iniPosition;
    Vector3 iniPositionR;

    Vector3 iniPositionRFoot;

    public float izq, up,forw;
    public float inix;
    // Start is called before the first frame update
    void Start()
    {
        reference = transform.GetChild(2).transform.position;
        LHand = transform.GetChild(2).GetChild(0).GetChild(3).gameObject;
        RHand = transform.GetChild(2).GetChild(0).GetChild(6).gameObject;
        RFoot = transform.GetChild(2).GetChild(5).gameObject;

        iniPosition = new Vector3(inix, 1.0f, 0.1f);
        iniPositionR = RHand.transform.position;

        LThumb = LHand.transform.GetChild(0).gameObject;
        LIndex = LHand.transform.GetChild(1).gameObject;
        LMiddle = LHand.transform.GetChild(2).gameObject;
        LRing = LHand.transform.GetChild(3).gameObject;
        LLittle = LHand.transform.GetChild(4).gameObject;

        RThumb = RHand.transform.GetChild(0).gameObject;
        RIndex = RHand.transform.GetChild(1).gameObject;
        RMiddle = RHand.transform.GetChild(2).gameObject;
        RRing = RHand.transform.GetChild(3).gameObject;
        RLittle = RHand.transform.GetChild(4).gameObject;

        iniPositionR = new Vector3(0.35f, 0.89f, 0);
        RHand.transform.position = gameObject.transform.position + transform.rotation * iniPositionR;

        iniPosition = new Vector3(-0.35f, 0.89f, 0);
        LHand.transform.position = gameObject.transform.position + transform.rotation * iniPosition;
    }
    IEnumerator PointingPosition()
    {
        StopCoroutine(RestingPosition());

        iniPositionRFoot = new Vector3(0.1169682f, -0.124f, -0.014534f);

        Vector3 iniPositionLThumb = new Vector3(-0.585f, -0.746f, 0.407f);
        Vector3 iniPositionLIndex = new Vector3(0.1176f, 0.0489f, 0.3291f);
        Vector3 iniPositionLMiddle = new Vector3(-0.121f, -1.308f, -1.041f);
        Vector3 iniPositionLRing = new Vector3(0.074f, -1.508f, -1.466f);
        Vector3 iniPositionLLittle = new Vector3(-0.121f, -1.351f, -0.96f);

        Vector3 iniPositionLHand = new Vector3(-0.24f, 1.45f, 0.63f);

        //LHand.transform.position = gameObject.transform.position + transform.rotation * Vector3.left * izq + transform.rotation * Vector3.forward * forw + transform.rotation * Vector3.up * up;
        RFoot.transform.position = gameObject.transform.position + transform.rotation * iniPositionRFoot;


        LThumb.transform.position = LHand.transform.position + transform.rotation * iniPositionLThumb;
        LIndex.transform.position = LHand.transform.position + transform.rotation * iniPositionLIndex;
        LMiddle.transform.position = LHand.transform.position + transform.rotation * iniPositionLMiddle;
        LRing.transform.position = LHand.transform.position + transform.rotation * iniPositionLRing;
        LLittle.transform.position = LHand.transform.position + transform.rotation * iniPositionLLittle;

        while (Vector3.Distance(LHand.transform.position, gameObject.transform.position + transform.rotation * iniPositionLHand) > 0.001)
        {
            LHand.transform.position= Vector3.Lerp(LHand.transform.position, gameObject.transform.position + transform.rotation * iniPositionLHand, 0.15f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return null;
    }

    IEnumerator RestingPosition()
    {
        StopCoroutine(PointingPosition());
        
        iniPosition = new Vector3(-0.35f, 0.89f, 0);
        iniPositionRFoot = new Vector3(0.1169682f, -0.021f, -0.014534f);
        Vector3 iniPositionLThumb = new Vector3(-0.077f, -0.055f, 0.091f);
        Vector3 iniPositionLIndex = new Vector3(-0.171f, -0.134f, 0.065f);
        Vector3 iniPositionLMiddle = new Vector3(-0.183f, -0.151f, 0.045f);
        Vector3 iniPositionLRing = new Vector3(-0.156f, -0.165f, 0.034f);
        Vector3 iniPositionLLittle = new Vector3(-0.117f, -0.182f, 0.024f);

        Vector3 iniPositionLHand = new Vector3(-0.35f, 0.89f, 0);


        //LHand.transform.position = gameObject.transform.position + transform.rotation * iniPosition;
        RFoot.transform.position = gameObject.transform.position + transform.rotation * iniPositionRFoot;

        LThumb.transform.position = gameObject.transform.position + transform.rotation * iniPositionLThumb;
        LIndex.transform.position = gameObject.transform.position + transform.rotation * iniPositionLIndex;
        LMiddle.transform.position = gameObject.transform.position + transform.rotation * iniPositionLMiddle;
        LRing.transform.position = gameObject.transform.position + transform.rotation * iniPositionLRing;
        LLittle.transform.position = gameObject.transform.position + transform.rotation * iniPositionLLittle;

        while (Vector3.Distance(LHand.transform.position, gameObject.transform.position + transform.rotation * iniPositionLHand) > 0.001)
        {
            LHand.transform.position = Vector3.Lerp(LHand.transform.position, gameObject.transform.position + transform.rotation * iniPositionLHand, 0.15f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return null;
    }



    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 10 * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //iniPositionRFoot = new Vector3(0.1169682f, -0.124f, -0.014534f);

            //Vector3 iniPositionLThumb = new Vector3(-0.585f, -0.746f, 0.407f);
            //Vector3 iniPositionLIndex = new Vector3(0.1176f, 0.0489f, 0.3291f);
            //Vector3 iniPositionLMiddle = new Vector3(-0.121f, -1.308f, -1.041f);
            //Vector3 iniPositionLRing = new Vector3(0.074f, -1.508f, -1.466f);
            //Vector3 iniPositionLLittle = new Vector3(-0.121f, -1.351f, -0.96f);

            //Vector3 iniPositionLHand = new Vector3(-0.24f, 1.45f, 0.63f);

            //LHand.transform.position = gameObject.transform.position + transform.rotation * iniPositionLHand;
            //RFoot.transform.position = gameObject.transform.position + transform.rotation * iniPositionRFoot;


            //LThumb.transform.position = LHand.transform.position + transform.rotation * iniPositionLThumb;
            //LIndex.transform.position = LHand.transform.position + transform.rotation * iniPositionLIndex;
            //LMiddle.transform.position = LHand.transform.position + transform.rotation * iniPositionLMiddle;
            //LRing.transform.position = LHand.transform.position + transform.rotation * iniPositionLRing;
            //LLittle.transform.position = LHand.transform.position + transform.rotation * iniPositionLLittle;
            StopCoroutine(RestingPosition());
            StartCoroutine(PointingPosition());
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //iniPositionR =new Vector3(0.35f, 0.89f, 0);
            //iniPosition = new Vector3(-0.35f, 0.89f, 0);
            //iniPositionRFoot = new Vector3(0.1169682f, -0.021f, -0.014534f);
            //Vector3 iniPositionLThumb = new Vector3(-0.077f, -0.055f, 0.091f);
            //Vector3 iniPositionLIndex = new Vector3(-0.171f, -0.134f, 0.065f);
            //Vector3 iniPositionLMiddle = new Vector3(-0.183f, -0.151f, 0.045f);
            //Vector3 iniPositionLRing = new Vector3(-0.156f, -0.165f, 0.034f);
            //Vector3 iniPositionLLittle = new Vector3(-0.117f, -0.182f, 0.024f);


            //LHand.transform.position = gameObject.transform.position + transform.rotation * iniPosition;
            //RHand.transform.position = gameObject.transform.position + transform.rotation * iniPositionR;
            //RFoot.transform.position = gameObject.transform.position + transform.rotation * iniPositionRFoot;

            //LThumb.transform.position = gameObject.transform.position + transform.rotation * iniPositionLThumb;
            //LIndex.transform.position = gameObject.transform.position + transform.rotation * iniPositionLIndex;
            //LMiddle.transform.position = gameObject.transform.position + transform.rotation * iniPositionLMiddle;
            //LRing.transform.position = gameObject.transform.position + transform.rotation * iniPositionLRing;
            //LLittle.transform.position = gameObject.transform.position + transform.rotation * iniPositionLLittle;

            StopCoroutine(PointingPosition());
            StartCoroutine(RestingPosition());


        }
    }
}
