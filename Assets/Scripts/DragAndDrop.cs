using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour
{
    private bool moveAllowed;

    private Collider2D collider;
    private StartGame sg;

    public GameObject DeathEffect;
    public GameObject SlectionRandomEffect;

    void Start()
    {
        sg = GameObject.FindGameObjectWithTag("SG").GetComponent<StartGame>();
        collider = GetComponent<Collider2D>();
    }
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (collider == touchedCollider)
                {
                    Instantiate(SlectionRandomEffect, transform.position, Quaternion.identity);
                    moveAllowed = true;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (moveAllowed)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }

        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Planet")
        {
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            sg.GameOver();
            Destroy(other.gameObject);
        }
    }
}
