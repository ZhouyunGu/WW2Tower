using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class justInTime : MonoBehaviour {

    public TextAsset jitText;
    public Text jitInfo;
    public GameObject jitObject;
    public GameObject jitInstruction;
    public string[] jitSentences;
    public int jitCurrentLine;
    public int jitEndOfLine;
    public bool jitBool;

    void Start () {
        jitBool = false;
        jitObject.SetActive(jitBool);
        jitInstruction.SetActive(jitBool);

        if(jitText != null)
        {
            jitSentences = (jitText.text.Split('\n'));
        }

        jitCurrentLine = 0;
        jitEndOfLine = jitSentences.Length - 1;
    }

   // Update is called once per frame
   void Update() {
        if (GameObject.FindGameObjectWithTag("Enemy"))
        {
            jitBool = true;
            jitObject.SetActive(jitBool);
            jitInstruction.SetActive(jitBool);
        }

        if (jitBool == true)
        {
            Time.timeScale = 0;
            if (jitCurrentLine <= jitEndOfLine)
            {
                jitInfo.text = jitSentences[jitCurrentLine];
            }
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                jitCurrentLine++;
            }
        } 

        if( jitCurrentLine > jitEndOfLine)
        {
            Time.timeScale = 1;
            jitBool = false;
            jitObject.SetActive(jitBool);
            jitInstruction.SetActive(jitBool);
            Destroy(jitObject);
            Destroy(jitInstruction);
        }
   }
}
