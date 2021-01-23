using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
