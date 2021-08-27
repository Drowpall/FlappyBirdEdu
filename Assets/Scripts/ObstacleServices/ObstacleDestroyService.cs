using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyService : MonoBehaviour
{
    public GameObject obstacle;

    void DestroyObstacle()
    {
        Destroy(gameObject, 6f);
    }

    void Update()
    {
        DestroyObstacle();
    }
}
