using System;
using UnityEngine;

public class MagnetPathrol : MonoBehaviour, IOrbLineHolder
{
    public Transform otherPlanet;

    private float speed;

    public event Action OnDeath;

    private void FixedUpdate()
    {
        CalculateSpeed();
        transform.position = Vector2.MoveTowards(transform.position, otherPlanet.position, speed * Time.deltaTime);
    }

    private void CalculateSpeed()
    {
        float dist = Vector3.Distance(otherPlanet.position, transform.position);
        if (dist < 4)
        {
            speed = 1;
        }
        else
        {
            speed = dist * 0.25f;
        }
        
    }

    private void OnDestroy()
    {
        OnDeath?.Invoke();  
    }
}
