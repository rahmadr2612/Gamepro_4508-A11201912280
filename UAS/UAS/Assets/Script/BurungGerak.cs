using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurungGerak : MonoBehaviour
{
    float nrandaom;
    // Start is called before the first frame update
    void Start()
    {
        nrandaom = Random.Range(-2.99f, 4.11f);
        transform.position = new Vector2(transform.position.x, nrandaom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 30, Time.deltaTime * 5);
    }
}
