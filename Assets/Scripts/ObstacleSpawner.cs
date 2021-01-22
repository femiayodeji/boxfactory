using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] ObstaclePrefab;
    public float spawnTime = 1;
    private float timer = 0;

    void Update()
    {
     if(timer > spawnTime)
     {
         int rand = Random.Range(0, ObstaclePrefab.Length);

         GameObject obstacle = Instantiate(ObstaclePrefab[rand]);
         obstacle.transform.position = transform.position + new Vector3(0, -1.05595f, -2.0f);
         Destroy(obstacle, 15);
         timer = 0;
     }
     timer += Time.deltaTime;
    }
}
