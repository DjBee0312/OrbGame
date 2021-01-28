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
        transform.position = Vector2.MoveTowards(transform.position, otherPlanet.position, speed * Time.deltaTime);
    }
}
