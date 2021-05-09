using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarDetector : MonoBehaviour
{
    public static AvatarDetector instance;

    public GameObject currentlyInteractingAvatar;

    public GameObject currentlyObservedAvatar;
    RaycastHit hit;

    public float distanceOfAvatarDetection;
    float timer;

    void Start()
    {
        if (AvatarDetector.instance) Destroy(this);
        AvatarDetector.instance = this;
    }

    // After two seconds, if the player hasn't seen a new avatar, the last one will be forgotten

    public void GreetAvatar()
    {
        if(currentlyObservedAvatar != null)
        {
            currentlyObservedAvatar.GetComponent<Interaction>().greeted = true;
        }
    }
    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                currentlyObservedAvatar = null;
            }
        }
    }
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * distanceOfAvatarDetection + transform.TransformDirection(Vector3.down);
        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Person"))
            {
                timer = 2;
                currentlyObservedAvatar = hit.collider.gameObject;
            }           
        }
        Debug.DrawRay(transform.position, forward, Color.green);
    }
}
