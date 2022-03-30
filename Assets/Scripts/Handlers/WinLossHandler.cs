using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLossHandler : MonoBehaviour
{
    public Canvas winLossDialogue;

    // Start is called before the first frame update
    void Start()
    {
        winLossDialogue.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnWin() 
    {
        //- what to do when a level is beaten -
        Debug.Log("Level Beaten!");
        //commence celebration
        winLossDialogue.enabled = true; //put up level end dialogue
        //wait for user input
        //go to next level
    }
}
