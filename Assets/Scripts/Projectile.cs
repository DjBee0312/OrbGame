using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Projectile : MonoBehaviour
{
    /*
    private Destroy ds;
    
    private GameObject[] planets;

    private Vector2 target;

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
    }
    
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.Translate(target.transform.forward * Time.deltaTime * projectileSpeed, Space.Self);
        Destroy(gameObject, 5);
        Instantiate(ds.DeathEffect, transform.position, Quaternion.identity, 5f);
    } */
}
