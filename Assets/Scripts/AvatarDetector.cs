using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarDetector : MonoBehaviour
{
    public static AvatarDetector instance;

    RaycastHit hit;

    public GameObject currentlyObservedAvatar;
    public GameObject currentlyInteractingAvatar;

    public bool avatarBeingForgotten = false;
    public float distanceOfAvatarDetection;


    void Start()
    {
        if (AvatarDetector.instance) Destroy(this);
        AvatarDetector.instance = this;
    }

    // After two seconds, if the player hasn't seen a new avatar, the last one will be forgotten
    IEnumerator forgetAvatar()
    {
        avatarBeingForgotten = true;
        yield return  new WaitForSeconds(2);
        if (avatarBeingForgotten) currentlyObservedAvatar = null;
        avatarBeingForgotten = false;
        yield return null;
    }
    public void GreetAvatar()
    {
        if(currentlyObservedAvatar != null)
        {
            currentlyObservedAvatar.GetComponent<Interaction>().greeted = true;
        }
    }
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * distanceOfAvatarDetection + transform.TransformDirection(Vector3.down);
        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Person"))
            {
                StopAllCoroutines();
                avatarBeingForgotten = false;
                currentlyObservedAvatar = hit.collider.gameObject;
            }
            else {
                if (currentlyObservedAvatar != null && !avatarBeingForgotten)
                {
                    StopAllCoroutines();
                    StartCoroutine(forgetAvatar());
                }
            }
        }
        Debug.DrawRay(transform.position, forward, Color.green);
    }
}
