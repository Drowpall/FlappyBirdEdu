using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {
    [SerializeField] Player player;
    [SerializeField] Spawner spawner;

    void Start() {
        player.Died += OnPlayerDied;
    }

    void OnPlayerDied() {
        spawner.enabled = false;
        foreach (var obstacle in FindObjectsOfType<Obstacle>()) {
            obstacle.enabled = false;
        }
    }
}
