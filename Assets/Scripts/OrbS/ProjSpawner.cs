using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjSpawner : MonoBehaviour
{
    public GameObject projectile;
    private float next_spawn_time;
    private float interval = 4f;
    
    void Start()
    {
        next_spawn_time = Time.time + interval;
        Instantiate(projectile);
    }
    
    void Update()
    {
        if(Time.time > next_spawn_time)
        {
            Instantiate(projectile);
            
            next_spawn_time += interval;
        }
    }
}
