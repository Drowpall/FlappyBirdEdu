using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float jmpForce = 6.5f;

    float addVelocity;
    
    private new Rigidbody2D rigidbody;

    private void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
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

        rigidbody.velocity += new Vector2(0, addVelocity);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }
}
