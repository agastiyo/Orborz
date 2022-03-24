using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsHandler : MonoBehaviour
{
    Rigidbody2D currentBall;
    const float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        currentBall = null;
    }

    // Update is called once per frame
    void Update()
    {
        currentBall.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, currentBall.velocity.y);
    }

    public void ChangeCurrentBall(Rigidbody2D newBall) 
    {
        if (currentBall) 
        {
            currentBall.velocity = new Vector2(0,0);    //Stop the ball from moving
        }
        currentBall = newBall;
    }
}
