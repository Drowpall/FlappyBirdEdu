using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float jumpForce = 6.5f;

    float additionalVelocity;
    
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
            additionalVelocity = -rigidbody.velocity.y + jumpForce;
        }
        else
        if (rigidbody.velocity.y < 1)
        {
            additionalVelocity = jumpForce;
        }
        else
        {
            additionalVelocity = jumpForce / rigidbody.velocity.y;
        }

        rigidbody.velocity += new Vector2(0, additionalVelocity);
    }
}
