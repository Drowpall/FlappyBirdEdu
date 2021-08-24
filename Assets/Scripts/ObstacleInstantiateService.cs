using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInstantiateService : MonoBehaviour
{
    static float resetCoolDownValue = 2f;
    float spawnCoolDown = resetCoolDownValue;

    public GameObject[] obstaclePrefabTypes;

    void SpawnObstacle()
    {
        if (spawnCoolDown < 0)
        {
            Instantiate(obstaclePrefabTypes[GetRandomPrefabType()]);
            spawnCoolDown = resetCoolDownValue;
        }
    }

    int GetRandomPrefabType() => Random.Range(1, 5);

    void DecreaseSpawnCooldown()
    {
        spawnCoolDown -= Time.deltaTime;
    }

    void Update()
    {
        DecreaseSpawnCooldown();
        SpawnObstacle();
    }
}
