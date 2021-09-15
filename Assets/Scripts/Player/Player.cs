using System;
using UnityEngine;

namespace PlayerLogic.PlayerMovement {
    public class Player : MonoBehaviour {
        public event Action Died;
        
        void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.GetComponentInParent<Obstacle>()) return;
            foreach (var script in GetComponents<MonoBehaviour>()) {
                script.enabled = false;
            }
            Died?.Invoke();
        }
    }
}