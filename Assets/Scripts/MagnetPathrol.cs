using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPathrol : MonoBehaviour
{
    public Transform otherPlanet;

    public float speed;

    private void FixedUpdate()
    {
        CalculateSpeed();
        transform.position = Vector2.MoveTowards(transform.position, otherPlanet.position, speed * Time.deltaTime);
    }

    private void CalculateSpeed()
    {
        float dist = Vector3.Distance(otherPlanet.position, transform.position);
        if (dist < 3)
        {
            print("Distance to other: " + dist);
            speed = 1;
        }
        else
        {
            print("Distance to other: " + dist);
            speed = dist * 0.5f;
        }
        
    }
}
