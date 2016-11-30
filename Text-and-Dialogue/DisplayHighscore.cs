using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DisplayHighscore : MonoBehaviour {

    public Text[] scoreText = new Text[6];
    public Text[] nameText = new Text[6];

	// Use this for initialization
	void Start () {
        string name = "HighscoreName";
        string score = "Highscore";

        for(int i = 1; i < 6; i++)
        {
            string tempScoreKey = (score + i).ToString();
            string tempNameKey = (name + i).ToString();

            scoreText[i].text = PlayerPrefs.GetInt(tempScoreKey).ToString();
            nameText[i].text = PlayerPrefs.GetString(tempNameKey);
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
