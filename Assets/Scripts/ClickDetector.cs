using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    ControlsHandler controlsHandler;

    // Start is called before the first frame update
    void Start()
    {
        controlsHandler = FindObjectOfType<ControlsHandler>();
    }

    void OnMouseDown() { controlsHandler.ChangeCurrentBall(GetComponent<Rigidbody2D>()); }
}

//Using the Unity Game Engine