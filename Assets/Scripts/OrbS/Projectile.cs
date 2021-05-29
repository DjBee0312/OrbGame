using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Projectile : MonoBehaviour
{
    
    private Destroy ds;
    private float destroyTime = 5f;
    
    private GameObject[] planets;

    private Vector3 target;
    private Vector3 direction;

    public float speed;

    private void Start()
    {
        planets = GameObject.FindGameObjectsWithTag("Planet");
        
        FindTarget();
    }

    private void FindTarget()
    {
        int rand = Random.Range(0, planets.Length);
        target = planets[rand].transform.position;
        direction = (target - transform.position).normalized;
    }
    
    private void Update()
    {
        transform.position += direction * (speed * Time.deltaTime);
        Destroy(gameObject, destroyTime);
    } 
    
}
