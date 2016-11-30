using UnityEngine;
using System.Collections;

public class Highscore : MonoBehaviour {
    const int NUMBER_OF_SCORE = 6;

	// Use this for initialization
	void Start () {
        int playerScore = ScoreManager.sManager.getScore();
        string name = ScoreManager.sManager.getName();

        string nameKey = "HighscoreName";
        string scoreKey = "Highscore";

        //Started from 1 instead of 0
        for (int i = 1; i < NUMBER_OF_SCORE; i++)
        {
            string namePlayerKey = (nameKey + i).ToString();
            string scorePlayerKey = (scoreKey + i).ToString();

            

            if (PlayerPrefs.HasKey(scorePlayerKey) == false || PlayerPrefs.HasKey(namePlayerKey) == false){
                PlayerPrefs.SetString(namePlayerKey, name);
                PlayerPrefs.SetInt(scorePlayerKey, playerScore);
            }
            int currentScore = PlayerPrefs.GetInt(scorePlayerKey);

            if(playerScore > currentScore)
            {
                int scoreTemp = currentScore;
                string nameTemp = PlayerPrefs.GetString(namePlayerKey);

                PlayerPrefs.SetString(namePlayerKey, name);
                PlayerPrefs.SetInt(scorePlayerKey, playerScore);

                playerScore = scoreTemp;
                name = nameTemp;
            }
        }

        for(int i = 1; i <NUMBER_OF_SCORE; i++)
        {
            string tempScoreKey = (scoreKey + i).ToString(); 
            string tempNameKey = (nameKey + i).ToString();
            print(PlayerPrefs.GetString(tempNameKey) + " " + PlayerPrefs.GetInt(tempScoreKey));
        }
	}
	
}
