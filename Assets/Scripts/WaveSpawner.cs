using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesPerWave = 5;
    public float spawnRadius = 10f;

    public void SpawnWave()
    {
        if (enemyPrefab == null) { Debug.LogWarning("Assign enemyPrefab first."); return; }
        for (int i = 0; i < enemiesPerWave; i++)
        {
            float angle = (Mathf.PI * 2f * i) / enemiesPerWave;
            Vector3 offset = new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * spawnRadius;
            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }
        Debug.Log("Spawned wave of " + enemiesPerWave + " enemies.");
    }
}
