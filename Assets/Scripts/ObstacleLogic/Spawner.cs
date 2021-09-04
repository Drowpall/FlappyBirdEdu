using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float spawnCooldown = 2f;
    float _spawnCooldown;

    public GameObject obstaclePrefab;

    private void Start()
    {
        _spawnCooldown = spawnCooldown;
    }

    void Update()
    {
        _spawnCooldown -= Time.deltaTime;

        if (_spawnCooldown < 0)
        {
            GameObject obstacle = Instantiate(obstaclePrefab);
            RandomizePosition(obstacle.GetComponent<Obstacle>());
            _spawnCooldown = spawnCooldown;
        }
    }

    void RandomizePosition(Obstacle ob)
    {
        ob.DistanceY = Random.Range(2.4f, 4f);
        ob.DistanceX = Random.Range(-3f, 3f);
        ob.CenterHeight = Random.Range(-2f, 2f);
    }
}
