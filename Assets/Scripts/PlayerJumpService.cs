using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpService : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float negativeVelocityAlter = 6f;
    [SerializeField, Range(1f, 10f)] float zeroVelocityAlter = 6f;
    [SerializeField, Range(1f, 10f)] float positiveVelocityAlter = 7f;

    bool isSpaceKeyPressed = false;
    float velocityAlteration;
    
    private new Rigidbody2D rigidbody;

    private void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
    }

    void ApplyVelocityAlteration()
    {
        if (rigidbody.velocity.y < 0)
        {
            velocityAlteration = -rigidbody.velocity.y + negativeVelocityAlter;
        }
        else
            if (rigidbody.velocity.y < 1)
        {
            velocityAlteration = zeroVelocityAlter;
        }
        else
        {
            velocityAlteration = positiveVelocityAlter / rigidbody.velocity.y;
        }

        rigidbody.velocity += new Vector2(0, velocityAlteration);

        isSpaceKeyPressed = false;
    }

    public void DisplayVelocity()
    {
        Debug.Log(rigidbody.velocity.y);
    }

    void MonitorSpaceKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpaceKeyPressed = true;
        }
    }

    void FixedUpdate()
    {
        if(isSpaceKeyPressed)
        {
            DisplayVelocity();
            ApplyVelocityAlteration();
        }
    }

    void Update()
    {
        MonitorSpaceKey();
    }
}
