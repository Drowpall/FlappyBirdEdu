using System;
using UnityEngine;

public class Player : MonoBehaviour {
    public int Score { get; private set; }
    public event Action Died;
    public event Action Scored;

    private void Start()
    {
        Scored += OnPlayerScored;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (!other.gameObject.GetComponentInParent<Obstacle>()) 
            return;
        foreach (var script in GetComponents<MonoBehaviour>()) {
            script.enabled = false;
        }
        Died?.Invoke();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerDeath")
        {
            Died?.Invoke();
        }
        
        if(collision.gameObject.tag == "ScorePoint")
        {
            Scored?.Invoke();
        }
    }

    public void OnPlayerScored()
    {
        Score += 1;
    }
} 