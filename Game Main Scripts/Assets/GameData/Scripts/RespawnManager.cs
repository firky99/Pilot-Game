using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [System.Serializable]
    public class TimeParts
    {
        public int minTime;
        public int maxTime;
        public int totalSpawning;
        public int totalEnemyType;
    }

    [SerializeField]
    GameObject[] Obstacle;
    [SerializeField]
    TimeParts[] timeParts;

    [SerializeField]
    Vector3 MinSpawningPosition;

	[SerializeField]
	Vector3 MaxSpawningPosition;

    int currentTimeSpawn;

    void Start()
    {
        currentTimeSpawn = 0;
    }

    void FixedUpdate()
    {
        for(int i = 0; i < timeParts.Length; i++)
        {
            if(currentTimeSpawn < (int)ScoreManager.instance.scoreCount)
            {
                if((int)ScoreManager.instance.scoreCount >= timeParts[i].minTime && 
                    (int)ScoreManager.instance.scoreCount < timeParts[i].maxTime)
                {   
                    for(int j = 0; j < timeParts[i].totalSpawning; j++)
                    {
                        GameObject temp = Instantiate(Obstacle[Random.Range(0,timeParts[i].totalEnemyType)], 
                            new Vector3(Random.Range(MinSpawningPosition.x, MaxSpawningPosition.x),
                                        Random.Range(MinSpawningPosition.y, MaxSpawningPosition.y),
                                        Random.Range(MinSpawningPosition.z, MaxSpawningPosition.z))
                            ,new Quaternion());

                        temp.transform.SetParent(transform);
                    }
                    currentTimeSpawn = (int)ScoreManager.instance.scoreCount;
                    break;
                }
            }
        }
    }
}
