using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    private float spawnTimer = 0.0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0.0f;
        }
    }

    void SpawnEnemy()
    {
        float spawnX = Random.Range(-8.0f, 8.0f);
        Vector2 spawnPosition = new Vector2(spawnX, transform.position.y);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
