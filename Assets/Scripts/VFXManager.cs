using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject VfxAudioSource;
    public GameObject VfxSwitchOn;
    public GameObject VfxSwitchOff;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(VfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitchOn(Vector3 spawnPosition)
    {
        GameObject.Instantiate(VfxSwitchOn, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitchOff(Vector3 spawnPosition)
    {
        GameObject.Instantiate(VfxSwitchOff, spawnPosition, Quaternion.identity);
    }
}
