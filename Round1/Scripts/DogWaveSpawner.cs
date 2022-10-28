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
        if(countdown <= 0f)     // 1����� 6�ʴ� enemy ����
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

        /*  enemy: waveIndex �����ϴ� ��ŭ ���� �� ����
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
