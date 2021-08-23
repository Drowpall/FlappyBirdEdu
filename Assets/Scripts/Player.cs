using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float maxVelocity = 10f;
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

    void FixedUpdate()
    {
        if(isSpaceKeyPressed == true)
        {
            Debug.Log(rigidbody.velocity.y);

            if (rigidbody.velocity.y < 0)
            {
                velocityAlteration = -rigidbody.velocity.y + negativeVelocityAlter;
            }
            else 
            if(rigidbody.velocity.y < 1)
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

        if (rigidbody.velocity.y > 0 && rigidbody.velocity.y > maxVelocity)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocity);
        }
        else if (rigidbody.velocity.y < 0 && rigidbody.velocity.y < -maxVelocity)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, -maxVelocity);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpaceKeyPressed = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}
