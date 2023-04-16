using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public KeyCode InputKey;
    public Collider Ball;
    public Material HoldMaterial;
    public Material ReleaseMaterial;

    public float MaxTimeHold;
    public float MaxForce;

    private bool _isHold = false;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == Ball)
        {
            ReadInput(Ball);
        }
    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(InputKey) && !_isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        _isHold = true;
        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(InputKey))
        {
            _renderer.material = HoldMaterial;
            force = Mathf.Lerp(0, MaxForce, timeHold / MaxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        _renderer.material = ReleaseMaterial;

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        _isHold = false;
    }
}
