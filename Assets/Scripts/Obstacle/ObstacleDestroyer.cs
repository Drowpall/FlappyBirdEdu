using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        var obstacle = other.GetComponentInParent<Obstacle>();
        if (obstacle != null) {
            Destroy(obstacle.gameObject);
        }
    }
}