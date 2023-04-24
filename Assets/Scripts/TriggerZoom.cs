using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoom : MonoBehaviour
{
    public Collider Ball;
    public CameraController CameraController;
    public float Length;

    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            CameraController.FollowTarget(Ball.transform, Length);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == Ball)
        {
            CameraController.GoBackToDefault();
        }
    }
}
