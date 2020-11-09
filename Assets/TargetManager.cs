using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour
{
    [SerializeField]
    private GameObject targetManager;

    private Text guiWelcome;
    private Text guiScore;
    private Text guiTargets;

    private int totalScore = 0;
    private int totalNumDestroyed = 0;

    private int totalEncountered = 0;

    // Start is called before the first frame update
    void Start()
    {
        guiWelcome = GameObject.Find("Text").GetComponent<Text>();
        guiWelcome.text = "Welcome to the GAME!";
        guiScore.text = "Total Score: " + totalScore.ToString();
        guiTargets.text = "Targets Encountered: " + totalEncountered.ToString();


    }

   
   
}
