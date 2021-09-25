using System;
using UnityEngine;

    public class Player : MonoBehaviour {
        public int Score { get; private set; }
        public event Action Died;
        
        void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.GetComponentInParent<Obstacle>()) return;
            foreach (var script in GetComponents<MonoBehaviour>()) {
                script.enabled = false;
            }
            Died?.Invoke();
        }

        public void IncrementScore()
        {
            Score += 1;
        }
    }