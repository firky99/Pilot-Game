using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] Obstacle;
    [SerializeField]
    float minTime, maxTime;
    float activeTime, time;

    [SerializeField]
    Vector3 SpawningPosition;

    void Start()
    {
        time = 0;
        activeTime = Random.Range(minTime, maxTime);
    }

    void FixedUpdate()
    {
        time += 1;
        if(time>=activeTime)
        {
            Instantiate(Obstacle[Random.Range(0,Obstacle.Length)], SpawningPosition, new Quaternion());

            time = 0;
            activeTime = Random.Range(minTime, maxTime);
        }
    }
}
