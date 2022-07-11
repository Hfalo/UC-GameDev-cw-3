using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    // will happen once and only once unlike the update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // its called every fixed frame-rate frame (for the physics)
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
    }


    // Update is called once per frame
    void Update()
    {

    }

}

