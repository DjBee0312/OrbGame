using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RandomPathrol : MonoBehaviour
{

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    private Vector2 targetPosition;

    private float minSpeed = 0.5f;
    private float maxSpeed = 2;
    private float speed;

    //public GameObject restartPanel;
    
    private float secondsToMaxDifficulty = 60;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPosition();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((Vector2) transform.position != targetPosition)
        {
            speed = Mathf.Lerp(minSpeed, maxSpeed, getDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

    

    float getDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
}
