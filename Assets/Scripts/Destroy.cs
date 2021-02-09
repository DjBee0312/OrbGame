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
        if (other.CompareTag("Planet") || other.CompareTag("Projectile"))
        {
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            sg.GameOver();
            Destroy(other.gameObject);
            FindObjectOfType<SoundManager>().Play("OrbDestruction");
            
        } else if (other.CompareTag("Boss") && gameObject.CompareTag("Planet"))
        {
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            sg.GameOver();
            Destroy(gameObject);
            FindObjectOfType<SoundManager>().Play("OrbDestruction");
        }
    }
}