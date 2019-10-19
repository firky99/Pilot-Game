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
    Vector3 MinSpawningPosition;

	[SerializeField]
	Vector3 MaxSpawningPosition;

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
            Instantiate(Obstacle[Random.Range(0,Obstacle.Length)], 
				new Vector3(Random.Range(MinSpawningPosition.x, MaxSpawningPosition.x),
							Random.Range(MinSpawningPosition.y, MaxSpawningPosition.y),
							Random.Range(MinSpawningPosition.z, MaxSpawningPosition.z))
				,new Quaternion());

            time = 0;
            activeTime = Random.Range(minTime, maxTime);
        }
    }
}
