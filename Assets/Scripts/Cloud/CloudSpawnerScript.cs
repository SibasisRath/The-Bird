using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject clouds;
    public float spawnRate =0.5f;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }

    private void SpawnCloud()
    {
        float highestpoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;
        Instantiate(clouds, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestpoint)), transform.rotation);
    }
}
