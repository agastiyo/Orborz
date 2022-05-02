using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsHandler : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D currentBall;
    private const float speed = 5f;
    public bool LevelRunning;

    // Start is called before the first frame update
    void Start()
    {
        LevelRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(LevelRunning) 
        {
            currentBall.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, currentBall.velocity.y);
        }
    }

    public void ChangeCurrentBall(Rigidbody2D newBall) 
    {
        currentBall.velocity = new Vector2(0,0);    //Stop the ball from moving
        currentBall = newBall;
        Debug.Log($"Now Controlling {newBall.name}");
    }
    public void NewLevel() 
    {
        currentBall = FindObjectOfType<MainOrb>().GetComponent<Rigidbody2D>();
        LevelRunning = true;
        Debug.Log($"Now Controlling {currentBall.name}");
    }
}

//Using the Unity Game Engine