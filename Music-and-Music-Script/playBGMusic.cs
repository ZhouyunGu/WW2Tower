using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playBGMusic : MonoBehaviour {

    public GameObject music;
	void Start ()
    {
        GameObject musicTemp = GameObject.FindGameObjectWithTag("BGM");
        if(musicTemp == null)
        {
            Instantiate(music, Vector3.zero, Quaternion.identity);
        }
	}
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene("Scene 2");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Scene 1");
        }
    }
	
}
