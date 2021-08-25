using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float moveSpeed = 3f;
    [SerializeField, Range(1f, 10f)] float destroyTimer = 6f;

    private void Start()
    {
        Destroy(gameObject, destroyTimer);
    }

    void Update()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
