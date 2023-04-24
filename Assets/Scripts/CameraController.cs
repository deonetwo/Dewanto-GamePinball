using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    public float ReturnTime;
    public float FollowSpeed;
    public float Length;
    public Transform TargetTransform;

    private Vector3 _defaultPosition;

    public bool HasTarget { get { return TargetTransform != null; } }

    private void Start()
    {
        _defaultPosition = transform.position;
        TargetTransform = null;
    }
    private void Update()
    {
        if (HasTarget)
        {
            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = TargetTransform.position + (targetToCameraDirection * Length);
            transform.position = Vector3.Lerp(transform.position, targetPosition, FollowSpeed * Time.deltaTime);
        }
    }

    public void FollowTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();
        TargetTransform = targetTransform;
        Length = targetLength;
    }

    public void GoBackToDefault()
    {
        TargetTransform = null;

        //move to default
        StopAllCoroutines();
        StartCoroutine(MovePosition(_defaultPosition, ReturnTime));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while(timer < time)
        {
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer/time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
