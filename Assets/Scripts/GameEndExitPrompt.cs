using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndExitPrompt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExitGameWait());
    }

    private IEnumerator ExitGameWait() 
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        Application.Quit();
    }
}

//Using the Unity Game Engine