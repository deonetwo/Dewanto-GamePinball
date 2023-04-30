using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider Ball;
    public Material OffMaterial;
    public Material OnMaterial;
    public float Score;

    public AudioManager AudioManager;
    public VFXManager VFXManager;
    public ScoreManager ScoreManager;

    private SwitchState _state;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            Toggle(other);
        }
    }
    
    private void Set(bool active)
    {
        if (active == true)
        {
            _state = SwitchState.On;
            _renderer.material = OnMaterial;
            StopAllCoroutines();
        }
        else
        {
            _state = SwitchState.Off;
            _renderer.material = OffMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle(Collider other)
    {
        if (_state == SwitchState.On)
        {
            Set(false);

            AudioManager.PlaySFXSwitchOff(other.transform.position);

            VFXManager.PlayVFXSwitchOff(other.transform.position);
        }
        else
        {
            Set(true);

            AudioManager.PlaySFXSwitchOn(other.transform.position);

            VFXManager.PlayVFXSwitchOn(other.transform.position);
        }

        ScoreManager.AddScore(Score);
    }

    private IEnumerator Blink(int times)
    {
        _state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            _renderer.material = OnMaterial;
            yield return new WaitForSeconds(0.5f);
            _renderer.material = OffMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        _state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
