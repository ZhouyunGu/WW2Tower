using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextLog : MonoBehaviour {

    public GameObject Textbox;
    public Text backgroundInfo;
    public TextAsset textFile;
    public string[] sentences;
    public int currentLine;
    public int endOfLine;

	// Use this for initialization
	void Start () {
	    if(textFile != null)
        {
            sentences = (textFile.text.Split('\n'));
        }

        currentLine = 0;
        endOfLine = sentences.Length-1;
	}
	
	// Update is called once per frame
	void Update () {

        if (currentLine <= endOfLine)
        {
            backgroundInfo.text = sentences[currentLine];

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine++;
        }

        if(currentLine > endOfLine)
        {
            Textbox.SetActive(false);
        }
	}
}
