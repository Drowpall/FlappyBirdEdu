using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour {
    public float speedX = 3f;

    [Range(0, 1)]
    public float rotationSpeed;

    Animator _animator;
    Rigidbody2D _rigidbody;

    static readonly int AnimatorJumpTrigger = Animator.StringToHash("jump");

    void Start() {
        _rigidbody = GetComponentInParent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        var jumper = GetComponentInParent<Jumper>();
        if (jumper != null)
            jumper.Jumped += OnJump;
        else
            Debug.LogError("No jumper in player animator!");
    }

    void Update() {
        float currentRotation = transform.rotation.z;
        float targetRotation = Vector2.SignedAngle(Vector2.right, new Vector2(speedX, _rigidbody.velocity.y));
        transform.rotation = Quaternion.Euler(0, 0, Mathf.LerpAngle(currentRotation, targetRotation, rotationSpeed));
    }

    void OnJump() {
        _animator.SetTrigger(AnimatorJumpTrigger);
    }
}