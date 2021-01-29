using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarDetector : MonoBehaviour
{

    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Person"))
            {
                Debug.Log("Person");
            }
        }
        Debug.DrawRay(transform.position, forward, Color.green);
    }
}
