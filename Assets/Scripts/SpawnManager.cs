using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;
    private Vector3 spawnPos = new Vector3(35, 0, 0);
    private PlayerController playerControllerScript;
    public GameObject[] obstaclePrefabs;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    public void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            int randomIndex = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[randomIndex], spawnPos, obstaclePrefabs[randomIndex].transform.rotation);
        }
    }
}
