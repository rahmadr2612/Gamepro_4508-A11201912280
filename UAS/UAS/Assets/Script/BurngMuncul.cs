using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurngMuncul : MonoBehaviour
{
    float time = 0;
    float timer = 1.5f;
    public GameObject burung;

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(burung, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

}
