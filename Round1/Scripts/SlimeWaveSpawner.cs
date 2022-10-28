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
        if (countdown <= 0f)     // 1����� 4�ʴ� enemy ����
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;    // 1���� waveIndex�� 1�� ����

        SpawnEnemy();
        yield return new WaitForSeconds(0.5f);
    }

    // enemyPrefab
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}