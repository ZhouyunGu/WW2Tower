using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    float masterVolume = 1;
    float musicVolume = 1;
    float sfxVolume = 1;

    public GameObject soundManager;

    public  AudioSource musicAudio;
    public  AudioSource sfxAudio;

    public static AudioManager instance;

    void Awake()
    {
        instance = this;
        GameObject newMAudio = new GameObject("Music Audio");
        musicAudio = newMAudio.AddComponent<AudioSource>();

        GameObject newSAudio = new GameObject("Sfx Audio");
        sfxAudio = newSAudio.AddComponent<AudioSource>();
        DontDestroyOnLoad(soundManager);
    }

    public void playSfx(AudioClip soundclip, Vector3 position)
    {
        AudioSource.PlayClipAtPoint(soundclip, position, sfxVolume * masterVolume);
    }

    public void playMusic(AudioClip musicclip)
    {
        musicAudio.clip = musicclip;
        musicAudio.Play();
    }

    public void setMasterVolume(float value)
    {
        masterVolume = value;
    }

    public void setMusicVolume(float value)
    {
        musicAudio.volume = value * masterVolume;
    }

    public void setSfxVolume(float value)
    {
        sfxAudio.volume = value * masterVolume;
    }
}
