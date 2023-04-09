using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode InputKey;
    
    private float _targetPressed;
    private float _targetReleased;
    private HingeJoint _hinge;

    // Start is called before the first frame update
    void Start()
    {
     _hinge = GetComponent<HingeJoint>();

     _targetPressed = _hinge.limits.max;
     _targetReleased = _hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring jointSpring = _hinge.spring;
        if(Input.GetKey(InputKey))
        {
         jointSpring.targetPosition = _targetPressed;
        }
        else
        {
         jointSpring.targetPosition = _targetReleased;
        }
        GetComponent<HingeJoint>().spring = jointSpring;
    }
}
