using System;
using DG.Tweening;
using UnityEngine;

public class Jumper : MonoBehaviour {
    public event Action Jumped;
    
    [SerializeField, Range(1f, 10f)] float jmpForce = 6.5f;

    float addVelocity;
    
    private new Rigidbody2D rigidbody;

    private void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (rigidbody.velocity.y < 0)
        {
            addVelocity = -rigidbody.velocity.y + jmpForce;
        }
        else
        if (rigidbody.velocity.y < 1)
        {
            addVelocity = jmpForce;
        }
        else
        {
            addVelocity = jmpForce / rigidbody.velocity.y;
        }

        DOTween.To(() => rigidbody.velocity.y, (float v) => rigidbody.velocity = new Vector2(0, v),
            rigidbody.velocity.y + addVelocity, 0.1f).SetEase(Ease.InCubic);
        // rigidbody.velocity += new Vector2(0, addVelocity);
        Jumped?.Invoke();
    }
}
