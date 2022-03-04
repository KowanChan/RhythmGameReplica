using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private float nextSpawnTime;
    public GameObject topPrefab;
    public GameObject botPrefeab;
    private float spawnDelay = 1;
    private float spawnType;
    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        spawnType = Random.Range(0.0f, 1.0f);

        if(spawnType < 0.5f)
        {
            Instantiate(botPrefeab);
        }

        else
        {
            Instantiate(topPrefab);
        }
    }

    private bool ShouldSpawn()
    {
        return Time.time > nextSpawnTime;
    }
}
