using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    void Update()
    {
        ManageMovement();
    }

    void ManageMovement()
    {
        float xPosition = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector2(xPosition, 0));
    }
}
