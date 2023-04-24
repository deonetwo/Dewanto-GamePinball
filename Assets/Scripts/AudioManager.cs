using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource BgmAudioSource;
    public GameObject SfxAudioSource;
    public GameObject SfxSwitchOnAudioSource;
    public GameObject SfxSwitchOffAudioSource;

    void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        BgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitchOn(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SfxSwitchOnAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitchOff(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SfxSwitchOffAudioSource, spawnPosition, Quaternion.identity);
    }
}
