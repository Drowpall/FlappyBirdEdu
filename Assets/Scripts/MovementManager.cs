using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float moveSpeed = 3f;

    void ManageMovement()
    {
        float xPosition = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector2(xPosition, 0));
    }

    void Update()
    {
        ManageMovement();
    }
}
