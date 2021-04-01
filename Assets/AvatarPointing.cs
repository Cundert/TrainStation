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

    Vector3 iniPosition;
    Vector3 iniPositionR;

    public float izq, up,forw;
    public float inix;
    // Start is called before the first frame update
    void Start()
    {
        reference = transform.GetChild(2).transform.position;
        LHand = transform.GetChild(2).GetChild(0).GetChild(3).gameObject;
        RHand = transform.GetChild(2).GetChild(0).GetChild(6).gameObject;

        iniPosition = new Vector3(inix, 1.0f, 0.1f);
        iniPositionR = RHand.transform.position;

        print(LHand.transform.position -transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 10 * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print(Vector3.forward);
            LHand.transform.position = gameObject.transform.position + transform.rotation*Vector3.left * izq + transform.rotation * Vector3.forward * forw + transform.rotation * Vector3.up * up;

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            iniPositionR =new Vector3(0.35f, 0.89f, 0);
            iniPosition = new Vector3(-0.35f, 0.89f, 0);


            LHand.transform.position = gameObject.transform.position + transform.rotation*iniPosition;
            RHand.transform.position = gameObject.transform.position + transform.rotation * iniPositionR;
        }
    }
}
