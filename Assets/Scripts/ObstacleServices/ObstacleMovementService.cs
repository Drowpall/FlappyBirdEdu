using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementService : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float moveSpeed = 3f;
    void ManageObstacleMovement()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    void Update()
    {
        ManageObstacleMovement();
    }
}
