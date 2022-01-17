using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    float time = 0;
    float timer = 0.8f;
    public GameObject rocks;

    
    void Update()
    {
        if (time <= 0)
        {
            Instantiate(rocks, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
    
}