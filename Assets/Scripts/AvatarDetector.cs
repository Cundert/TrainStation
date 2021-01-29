using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarDetector : MonoBehaviour
{

    RaycastHit hit;

    public GameObject currentlyObservedAvatar;
    bool avatarBeingForgotten = false;
    // After two seconds, if the player hasn't seen a new avatar, the last one will be forgotten
    IEnumerator forgetAvatar()
    {
        avatarBeingForgotten = true;
        yield return  new WaitForSeconds(2);
        if(avatarBeingForgotten) currentlyObservedAvatar = null;
        avatarBeingForgotten = false;
        yield return null;
    }
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10 + transform.TransformDirection(Vector3.down);
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
            ObservedAvatar.instance.setAvatar(currentlyObservedAvatar);
        }
        Debug.DrawRay(transform.position, forward, Color.green);
    }
}
