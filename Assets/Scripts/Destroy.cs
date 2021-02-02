using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private StartGame sg;
    
    public GameObject DeathEffect;
    
    void Start()
    {
        sg = GameObject.FindGameObjectWithTag("SG").GetComponent<StartGame>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Planet"))
        {
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            sg.GameOver();
            Destroy(other.gameObject);
        }
    }
}
