using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float moveSpeed = 3f;
    [SerializeField, Range(1f, 10f)] float destroyTimer = 6f;

    public float DistanceX { get; set; }
    public float DistanceY { get; set; }
    public float CenterHeight { get; set; }

    [SerializeField] GameObject topObstacle;
    [SerializeField] GameObject bottomObstacle;

    private void Start()
    {
        Init();
        Destroy(gameObject, destroyTimer);
    }

    private void Init()
    {
        topObstacle.transform.position += new Vector3(DistanceX / 2, CenterHeight + DistanceY / 2, 0f);
        bottomObstacle.transform.position += new Vector3(-DistanceX / 2, CenterHeight - DistanceY / 2, 0f);
    }

    void Update()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
