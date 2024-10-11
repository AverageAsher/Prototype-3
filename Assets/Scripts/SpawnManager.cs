using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(30, 0, 0);

    public float startDelay = 2.0f;
    public float repeatRate = 3.0f;

    // Reference to the PlayerController script
    private PlayerController playerControllerScript;

    void Start()
    {
        // Find the Player GameObject and get the PlayerController component
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        // Call the SpawnObstacle method at intervals
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        // Only spawn obstacles if gameOver is false
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
