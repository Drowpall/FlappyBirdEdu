using System;
using PlayerLogic.PlayerMovement;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    [SerializeField, Range(1f, 10f)] float moveSpeed = 3f;

    [SerializeField] GameObject topObstacle;
    [SerializeField] GameObject bottomObstacle;

    void Update()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
    
    public void SetupObstaclePositions(Vector2 distanceBetweenObstacles, float centerHeight)
    {
        topObstacle.transform.position += new Vector3(distanceBetweenObstacles.x / 2, centerHeight + distanceBetweenObstacles.y / 2, 0f);
        bottomObstacle.transform.position += new Vector3(-distanceBetweenObstacles.x / 2, centerHeight - distanceBetweenObstacles.y / 2, 0f);
    }    
}
