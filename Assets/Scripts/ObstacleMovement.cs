using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f;
    GameObject scoreUIText;

    void Start()
    {
        scoreUIText = GameObject.FindGameObjectWithTag("ScoreText");
    }
    
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;    
    }

    void OnTriggerEnter(Collider collider)
    {
        if((collider.tag == "Player"))
        {
            Score.score++;
        }
    }
}
