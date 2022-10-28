using UnityEngine;
using System.Collections;

public class DogWaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    public float countdown = 3f;

    private int waveIndex = 0;

    void Update()
    {
        if(countdown <= 0f)     // 1라운드는 6초당 enemy 등장
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

        /*  enemy: waveIndex 증가하는 만큼 마리 수 증가
        for (int i=0; i<waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        */
    }

    // enemyPrefab
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
