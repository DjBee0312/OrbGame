using System.Collections;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool moveAllowed;

    private Collider2D collider;
    private SoundManager sound;

    public GameObject SlectionRandomEffect;
    public GameObject MovingRandomEffect;
    public bool moveEnabled;
    void Start()
    {
        moveEnabled = true;
        collider = GetComponent<Collider2D>();
        sound = FindObjectOfType<SoundManager>();
        StartCoroutine(IEMoveOrb());
    }


    public IEnumerator IEMoveOrb()
    {
        while (moveEnabled)
        {
            yield return new WaitForEndOfFrame();
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                if (touch.phase == TouchPhase.Began)
                {
                    Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                    if (collider == touchedCollider)
                    {
                        sound.Play("Touch");
                        Instantiate(SlectionRandomEffect, transform.position, Quaternion.identity);
                        moveAllowed = true;
                    }
                }

                if (touch.phase == TouchPhase.Moved)
                {
                    if (moveAllowed)
                    {
                        Instantiate(MovingRandomEffect, transform.position, Quaternion.identity);
                        transform.position = new Vector2(touchPosition.x, touchPosition.y);
                    }
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    moveAllowed = false;
                }

            }
        }
    }
}