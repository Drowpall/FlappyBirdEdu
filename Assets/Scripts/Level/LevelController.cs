using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
    [SerializeField] Player player;
    [SerializeField] Spawner spawner;

    [SerializeField] UIController uiController;
    [SerializeField] BackgroundController backgroundController;

    void Start() 
    {
        player.Died += OnPlayerDied;
    }

    void OnPlayerDied() 
    {
        spawner.enabled = false;
        foreach (var obstacle in FindObjectsOfType<Obstacle>()) {
            obstacle.enabled = false;
        }
        uiController.PlayDeathSceneUI();
        backgroundController.StopBackgroundMovement();
    }

    public void Restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
