using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefabs;
    [SerializeField] private float spawnRatePerSecond;
    [SerializeField] private float spawnPosX;
    [SerializeField] private float upLimitY;
    [SerializeField] private float lowLimitY;
    [SerializeField] private ObjectPool pool;
    [SerializeField] private float waitTime;

    private void Start()
    {
        
        StartCoroutine(SpawnRoutine());
    }
    

    private IEnumerator SpawnRoutine()
    {
        while (!GameController.isGameOver)
        {
            yield return new WaitForSeconds(waitTime);
            SpawnObstacle();
        }
        
    }
    
    private void SpawnObstacle()
    {
        var randomPosY = Random.Range(lowLimitY, upLimitY);
        var spawnPos = new Vector2(spawnPosX, randomPosY);
        
        GameObject obj = pool.GetPooledObject();
        obj.transform.position = spawnPos;
    }
}
