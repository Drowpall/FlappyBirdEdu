using System;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    [SerializeField, Range(1f, 10f)] float moveSpeed = 3f;

    [SerializeField] GameObject topObstacle;
    [SerializeField] GameObject bottomObstacle;
    [SerializeField] GameObject scoreTrigger;

    void Update()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
    
    public void SetupObstaclePositions(Vector2 distanceBetweenObstacles, float centerHeight)
    {
        topObstacle.transform.position += new Vector3(distanceBetweenObstacles.x / 2 + 10f, centerHeight + distanceBetweenObstacles.y / 2, 0f);
        bottomObstacle.transform.position += new Vector3(-distanceBetweenObstacles.x / 2 + 10f, centerHeight - distanceBetweenObstacles.y / 2, 0f);
        scoreTrigger.transform.position += new Vector3(10f, 0f, 0f);
    }
}
