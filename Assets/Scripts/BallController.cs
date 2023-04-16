using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float MaxSpeed;
    private Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (_rigidBody.velocity.magnitude > MaxSpeed)
        {
            _rigidBody.velocity = _rigidBody.velocity.normalized * MaxSpeed;
        }
    }
}
