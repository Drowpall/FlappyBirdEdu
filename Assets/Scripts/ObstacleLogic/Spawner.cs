using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float spawnCooldown = 2f;
    float _spawnCooldown;

    public GameObject[] obstaclePrefabs;

    private void Start()
    {
        _spawnCooldown = spawnCooldown;
    }

    void Update()
    {
        _spawnCooldown -= Time.deltaTime;

        if (_spawnCooldown < 0)
        {
            Instantiate(obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length - 1)]);
            _spawnCooldown = spawnCooldown;
        }
    }
}
