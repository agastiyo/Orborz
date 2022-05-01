using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLossHandler : MonoBehaviour
{
    [HideInInspector] public ControlsHandler controlsHandler;
    public int[] levelList = {1,2,3,4,5};
    public int currentLevelPos;

    public Canvas winLossDialogue;

    // Start is called before the first frame update
    void Start()
    {
        controlsHandler = FindObjectOfType<ControlsHandler>();
        currentLevelPos = 0;
        InitializeLevel(currentLevelPos, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnWin() 
    {
        //- what to do when a level is beaten -
        Debug.Log("Level Beaten!");
        controlsHandler.LevelRunning = false;
        winLossDialogue.enabled = true; //put up level end dialogue
        StartCoroutine(WaitForSpace());
    }

    public void InitializeLevel(int currentLevelPos, bool PreviousLevelIsLoaded) 
    {
        if(PreviousLevelIsLoaded) 
        {
            StartCoroutine(UnloadScene(levelList[currentLevelPos-1]));
        }

        controlsHandler.LevelRunning = false;
        winLossDialogue.enabled = false;
        StartCoroutine(LoadScene(levelList[currentLevelPos]));
    }

    private IEnumerator LoadScene(int SceneToLoad) 
    {
        AsyncOperation loadOp = SceneManager.LoadSceneAsync(SceneToLoad, LoadSceneMode.Additive);
        yield return new WaitUntil(() => loadOp.isDone);
        controlsHandler.NewLevel();
    }

    private IEnumerator UnloadScene(int SceneToUnload) 
    {
        AsyncOperation unloadOp = SceneManager.UnloadSceneAsync(SceneToUnload);
        yield return new WaitUntil(() => unloadOp.isDone);
    }

    private IEnumerator WaitForSpace() 
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        currentLevelPos++;
        try { InitializeLevel(currentLevelPos, true); }
        catch { SceneManager.LoadScene("GameEnd", LoadSceneMode.Additive); }
    }
}
