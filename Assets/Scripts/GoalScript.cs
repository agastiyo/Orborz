using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    [HideInInspector] WinLossHandler winLossHandler;

    // Start is called before the first frame update
    void Start()
    {
        winLossHandler = FindObjectOfType<WinLossHandler>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MainOrb>()) { winLossHandler.OnWin(); } 
        //if its the main ball, tell the win loss handler that level is beaten
    }
}
