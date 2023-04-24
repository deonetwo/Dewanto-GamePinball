using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider Ball;
    public float Multiplier;
    public Color BumperColor;

    public AudioManager AudioManager;
    public VFXManager VFXManager;

    private Renderer _renderer;
    private Animator _animator;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _animator = GetComponent<Animator>();

        _renderer.material.color = BumperColor;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.collider == Ball)
        {
            Rigidbody ballRig = Ball.GetComponent<Rigidbody>();
            ballRig.velocity *= Multiplier;

            _animator.SetTrigger("hit");

            AudioManager.PlaySFX(collision.transform.position);

            VFXManager.PlayVFX(collision.transform.position);
        }
    }
}
