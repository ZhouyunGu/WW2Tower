using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeInTime : MonoBehaviour {

    public TextAsset uitText;
    public Text uitInfo;
    public GameObject uitObject;
    public GameObject uitInstruction;
    public string[] uitSentences;
    public int uitCurrentLine;
    public int uitEndOfLine;
    public bool uitBool;

    // Use this for initialization
    void Start () {
        uitBool = false;
        uitObject.SetActive(uitBool);
        uitInstruction.SetActive(uitBool);

        if(uitText != null)
        {
            uitSentences = (uitText.text.Split('\n'));
        }

        uitCurrentLine = 0;
        uitEndOfLine = uitSentences.Length - 1;
	}
	
	// Update is called once per frame
	void Update () {
        //change the false in the if statement to the score they need to get the first upgrade
        if (true)
        {
            uitBool = true;
            uitObject.SetActive(uitBool);
            uitInstruction.SetActive(uitBool);
        }

        if(uitBool == true)
        {
            Time.timeScale = 0;
            if(uitCurrentLine <= uitEndOfLine)
            {
                uitInfo.text = uitSentences[uitCurrentLine];
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                uitCurrentLine++;
            }
        }

        if(uitCurrentLine > uitEndOfLine)
        {
            Time.timeScale = 1;
            uitBool = false;
            uitObject.SetActive(uitBool);
            uitInstruction.SetActive(uitBool);
        }
	}
}
