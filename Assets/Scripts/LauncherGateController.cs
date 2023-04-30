using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherGateController : MonoBehaviour
{
    public Collider Ball;

    private BoxCollider Gate;
    private MeshRenderer GateMesh;

    private void Start()
    {
        Gate = GetComponent<BoxCollider>();
        GateMesh = GetComponent<MeshRenderer>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == Ball)
        {
            Gate.isTrigger = false;
            GateMesh.enabled = true;
        }
    }
}
