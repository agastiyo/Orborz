using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody2D rb;
    const float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
    }
}
