using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

    public int score;
    public string playerName;
    public static ScoreManager sManager;

    void Awake()
    {
        if(sManager == null)
        {
            sManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void setScore(int a)
    {
        score = a;
    }

    public int getScore()
    {
        return score;
    }

    public void upScore(int a)
    {
        score += a;
    }

    public void downScore(int a)
    {
        if (score <= 0)
        {
            score = 0;
        }
        else
        {
            score -= a;
        }
    }

    public void setName(string a)
    {
        playerName = a;

    }

    public string getName()
    {
        return playerName;
    }
}
