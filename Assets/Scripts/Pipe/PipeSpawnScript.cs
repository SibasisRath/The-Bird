using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
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
            SpawnPipe();
            timer = 0;
        }
       
    }
    void SpawnPipe()
    {
        float highestpoint = transform.position.y+heightOffset;
        float lowestPoint = transform.position.y - heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestpoint)), transform.rotation);
    }
}
