using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPointing : MonoBehaviour
{
    Vector3 reference;
    public float x, y, z;
    GameObject LHand;
    Vector3 iniPosition;
    // Start is called before the first frame update
    void Start()
    {
        reference = transform.GetChild(2).transform.position;
        LHand = transform.GetChild(2).GetChild(0).GetChild(3).gameObject;
        iniPosition = LHand.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LHand.transform.position = gameObject.transform.position + new Vector3(x, y, z);

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            LHand.transform.position = gameObject.transform.position + iniPosition;

        }
    }
}
