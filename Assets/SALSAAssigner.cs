using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SALSAAssigner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        int layer = other.gameObject.layer;

        if (tag=="Passerby" && layer == LayerMask.NameToLayer("Person"))
        {
            other.gameObject.AddComponent<CrazyMinnow.SALSA.Fuse.CM_FuseSetup>();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        string tag = other.gameObject.tag;
        int layer = other.gameObject.layer;

        if (tag == "Passerby" && layer == LayerMask.NameToLayer("Person"))
        {
            var comps = other.gameObject.GetComponents<CrazyMinnow.SALSA.RandomEyes3D>();

            foreach (var comp in comps){
                Destroy(comp);
            }

            Destroy(other.gameObject.GetComponent<CrazyMinnow.SALSA.Salsa3D>());
            Destroy(other.gameObject.GetComponent<CrazyMinnow.SALSA.Fuse.CM_FuseSync>());
        }

    }
}
