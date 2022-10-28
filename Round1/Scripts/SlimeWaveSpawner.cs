using UnityEngine;
using System.Collections;

public class SlimeWaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    public float countdown = 1f;

    private int waveIndex = 0;

    void Update()
    {
        if (countdown <= 0f)     // 1라운드는 4초당 enemy 등장
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;    // 1라운드 waveIndex는 1로 고정

        SpawnEnemy();
        yield return new WaitForSeconds(0.5f);
    }

    // enemyPrefab
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}