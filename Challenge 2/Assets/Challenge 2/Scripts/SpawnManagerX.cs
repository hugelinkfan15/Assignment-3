using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private HealthSystem healthSystem;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        StartCoroutine(SpawnRandomBallCoRoutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int spawnIndex = Random.Range(0, ballPrefabs.Length-1);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnIndex], spawnPos, ballPrefabs[spawnIndex].transform.rotation);
    }

    IEnumerator SpawnRandomBallCoRoutine()
    {
        yield return new WaitForSeconds(3.0f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomBall();

            yield return new WaitForSeconds(Random.Range(3.0f, 5.0f));
        }
    }
}
