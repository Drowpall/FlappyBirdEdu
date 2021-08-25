using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float SpawnCooldown = 2f;
    float _spawnCoolDown;

    public GameObject[] obstaclePrefabs;

    private void Start()
    {
        _spawnCoolDown = SpawnCooldown;
    }

    void Update()
    {
        _spawnCoolDown -= Time.deltaTime;

        if (_spawnCoolDown < 0)
        {
            Instantiate(obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length - 1)]);
            _spawnCoolDown = SpawnCooldown;
        }
    }
}
