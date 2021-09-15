using PlayerLogic.PlayerMovement;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnCooldown;       //(2f)

    [SerializeField] Vector2 distanceXRange;    //(-3f,  3f);
    [SerializeField] Vector2 distanceYRange;    //(2.4f, 4f);
    [SerializeField] Vector2 centerHeightRange; //(-2f,  2f);

    float _spawnCooldown;

    public Obstacle obstaclePrefab;

    private void Start()
    {
        _spawnCooldown = spawnCooldown;
    }

    void Update()
    {
        _spawnCooldown -= Time.deltaTime;

        if (_spawnCooldown < 0)
        {
            var obstacle = Instantiate(obstaclePrefab);
            RandomizePosition(obstacle.GetComponent<Obstacle>());
            _spawnCooldown = spawnCooldown;
        }
    }

    void RandomizePosition(Obstacle ob)
    {
        var obstacleCoordinates = new Vector2(Random.Range(distanceXRange.x, distanceXRange.y), Random.Range(distanceYRange.x, distanceYRange.y));
        var centerPointHeight = Random.Range(centerHeightRange.x, centerHeightRange.y);

        ob.SetupObstaclePositions(obstacleCoordinates, centerPointHeight);
    }
}
