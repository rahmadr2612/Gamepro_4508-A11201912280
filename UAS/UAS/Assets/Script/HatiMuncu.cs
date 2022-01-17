using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatiMuncu : MonoBehaviour
{
    float time = 0;
    float timer = 10.2f;
    public GameObject hati;

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(hati, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

}