using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVelocityLimiter : MonoBehaviour
{
    [SerializeField] float maxVelocity = 10f;

    private new Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void LimitMaxVelocity()
    {
        if (rigidbody.velocity.y > 0 && rigidbody.velocity.y > maxVelocity)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocity);
        }
        else if (rigidbody.velocity.y < 0 && rigidbody.velocity.y < -maxVelocity)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, -maxVelocity);
        }
    }

    void Update()
    {
        LimitMaxVelocity();
    }
}
