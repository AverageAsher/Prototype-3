using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(30, 0, 0);

    // Variables to control the start delay and repeat rate
    public float startDelay = 2.0f;
    public float repeatRate = 3.0f;

    void Start()
    {
        // Call the SpawnObstacle method at intervals
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        // Instantiate the obstacle prefab at the spawn position with no rotation
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
