using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public float decreaseTime;
    public float minTime;

    public float timeToSpawn;
    public float startTimeSpawn;
    void FixedUpdate()
    {
        if (timeToSpawn <= 0) //se o tempo para spawnar for menor ou igual a 0
        {
            // o objeto sera spawnado sem rotacao:
            int rand = Random.Range(0, enemy.Length);
            Instantiate(enemy[rand], transform.position, Quaternion.identity);
            timeToSpawn = startTimeSpawn; // o spawn vai ter x segundos antes de spawnar outro objeto

            if (startTimeSpawn > minTime)
            {
                startTimeSpawn -= decreaseTime;
            }
        }
        // senao, o tempo pra spawn vai ser descrescido 
        else
        {
            timeToSpawn -= Time.deltaTime;
        }

    }
}
