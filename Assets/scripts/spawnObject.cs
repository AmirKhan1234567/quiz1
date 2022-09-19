using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    private float StartDelay = 2;
    private float spawnInterval = 5f;
    public GameObject [] balls;
    private float spawnrangex = 13;
    private float spawnposy = 9;



    void Start()
    {
        InvokeRepeating("SpawnRandomballs", StartDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomballs()
    {
        Vector3 spawn = new Vector3(Random.Range(-spawnrangex, spawnrangex), 9, -2);
       GameObject ball =  Instantiate(balls[Random.Range(0, balls.Length)], spawn, balls[Random.Range(0, balls.Length)].transform.rotation);
        int Factor = Random.Range(2,5);
        ball.transform.localScale = new Vector3(Factor, Factor, Factor);
    }
}
