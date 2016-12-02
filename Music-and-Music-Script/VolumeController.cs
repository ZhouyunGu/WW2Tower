using UnityEngine;
using System.Collections;

public class VolumeController : MonoBehaviour {

    public void menuSetMasterVolume(float value)
    {
        AudioManager.instance.setMasterVolume(value);
    }

    public void menuSetMusicVolume(float value)
    {
        AudioManager.instance.setMusicVolume(value);
    }

    public void menuSetSfxVolume(float value)
    {
        AudioManager.instance.setSfxVolume(value);
    }
}
