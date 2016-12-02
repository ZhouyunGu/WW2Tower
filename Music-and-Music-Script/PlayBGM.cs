using UnityEngine;
using System.Collections;

public class PlayBGM : MonoBehaviour {

    public GameObject music;
    public AudioClip Bgm;
    void Start()
    {
        GameObject musicTemp = GameObject.FindGameObjectWithTag("BGM");
        if (musicTemp == null)
        {
            Instantiate(music, Vector3.zero, Quaternion.identity);
        }

        AudioManager.instance.playMusic(Bgm);

        DontDestroyOnLoad(music);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
