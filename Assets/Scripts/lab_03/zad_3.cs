using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad_3 : MonoBehaviour
{
    public float speed = 1.0f;

    private Vector3 direction;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x <= 0)
        {
            direction = new Vector3(10, 0, 0);
        }
        if (transform.position.x >= 10)
        {
            direction = new Vector3(0, 0, 0);
        }
        transform.position = Vector3.MoveTowards(transform.position, direction, speed * Time.deltaTime);
    }
}
